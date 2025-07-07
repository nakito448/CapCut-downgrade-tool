using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CapCutVersionEditor
{
    public partial class Form1 : Form
    {
        string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string appsPath;
        string draftsPath;

        public Form1()
        {
            InitializeComponent();
            appsPath = Path.Combine(userPath, @"AppData\\Local\\CapCut\\Apps");
            draftsPath = Path.Combine(userPath, @"AppData\\Local\\CapCut\\User Data\\Projects\\com.lveditor.draft");

            CarregarVersoes();
            CarregarProjetos();
        }

        private void CarregarVersoes()
        {
            if (Directory.Exists(appsPath))
            {
                var versoes = Directory.GetDirectories(appsPath)
                    .Select(Path.GetFileName)
                    .Select(v =>
                    {
                        var partes = v.Split('.');
                        if (partes.Length >= 3)
                            return string.Join(".", partes.Take(3));
                        else
                            return v;
                    })
                    .Distinct()
                    .OrderByDescending(v => v)
                    .ToArray();

                comboBoxVersoesCapCut.Items.AddRange(versoes);
                if (comboBoxVersoesCapCut.Items.Count > 0)
                    comboBoxVersoesCapCut.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Pasta de versões do CapCut não encontrada.");
            }
        }

        private void CarregarProjetos()
        {
            if (Directory.Exists(draftsPath))
            {
                var projetos = Directory.GetDirectories(draftsPath)
                    .Select(Path.GetFileName)
                    .ToArray();

                comboBoxProjetos.Items.AddRange(projetos);
                if (comboBoxProjetos.Items.Count > 0)
                    comboBoxProjetos.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Pasta de projetos não encontrada.");
            }
        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            string versaoSelecionada = comboBoxVersoesCapCut.SelectedItem?.ToString();
            string projetoSelecionado = comboBoxProjetos.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(versaoSelecionada) || string.IsNullOrEmpty(projetoSelecionado))
            {
                MessageBox.Show("Selecione uma versão e um projeto.");
                return;
            }

            string projetoPath = Path.Combine(draftsPath, projetoSelecionado);
            string jsonPath = Path.Combine(projetoPath, "draft_content.json");
            string backupPath = Path.Combine(projetoPath, "draft_content_backup.json");

            if (File.Exists(jsonPath))
            {
                // Criar backup antes
                File.Copy(jsonPath, backupPath, true);

                string conteudo = File.ReadAllText(jsonPath);
                conteudo = ReplaceJsonVersion(conteudo, "new_version", versaoSelecionada);
                conteudo = ReplaceJsonVersion(conteudo, "app_version", versaoSelecionada);
                File.WriteAllText(jsonPath, conteudo);

                MessageBox.Show("Versão aplicada com sucesso. Backup salvo como 'draft_content_backup.json'.");
            }
            else
            {
                MessageBox.Show("Arquivo draft_content.json não encontrado no projeto selecionado.");
            }
        }

        private string ReplaceJsonVersion(string json, string key, string novaVersao)
        {
            int index = json.IndexOf($"\"{key}\":\"");
            if (index == -1) return json;
            int start = index + key.Length + 4;
            int end = json.IndexOf("\"", start);
            if (end == -1) return json;
            return json.Substring(0, start) + novaVersao + json.Substring(end);
        }
    }
}