using System.IO;
using System.Threading.Tasks;

namespace Editor
{
    public partial class frmEditor : Form
    {
        bool saved = false;
        string path = "";
        string texto = "";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void sfdEditor_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();


            if (ofdEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(ofdEditor.FileName);

                }
            }
        }
        private void guardar()
        {
            if (sfdEditor1.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor1.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);

                }
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                guardar();
                saved = true;

            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            tssStatus.Text = palabras.Length.ToString() + " Palabras";
        }

        private void tssStatus_Click(object sender, EventArgs e)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string[] parrafos = texto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            MessageBox.Show("Estadísticas: \n\nPalabras: " + tssStatus.Text + "\nLetras (con espacio): " + texto.Length.ToString() +
                "\n Párrafos: " + parrafos.Length.ToString(), "Contador de palabras");

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ftdEditor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.Font = ftdEditor.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cldEditor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.ForeColor = cldEditor.Color;
            }
        }
    }
}
