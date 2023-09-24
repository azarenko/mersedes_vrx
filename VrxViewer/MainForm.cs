using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VrxViewer
{
    public partial class MainForm : Form
    {
        private VrxParser vrxParser1;
        private VrxParser vrxParser2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void file1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                vrxParser1 = new VrxParser(openFileDialog1.FileName);
                BuildTree();
            }
        }

        private void file2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                vrxParser2 = new VrxParser(openFileDialog1.FileName);
                BuildTree();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BuildTree()
        {
            _componetsList.Nodes.Clear();

            if (vrxParser1?.VehicleReport != null)
                foreach (var component in vrxParser1.VehicleReport.ComponentList)
                {
                    if (component.CommunicationState != 6)
                        continue;

                    if (!ContainsNode(_componetsList.Nodes, component.ECUShortName))
                        _componetsList.Nodes.Add(component.ECUShortName);
                }

            if (vrxParser2?.VehicleReport != null)
                foreach (var component in vrxParser2.VehicleReport.ComponentList)
                {
                    if (component.CommunicationState != 6)
                        continue;

                    if (!ContainsNode(_componetsList.Nodes, component.ECUShortName))
                        _componetsList.Nodes.Add(component.ECUShortName);
                }

            foreach (TreeNode node in _componetsList.Nodes)
            {
                node.ForeColor = Compare(node.Text);
            }

            _componetsList.Sort();
        }

        private Color Compare(string ecuName)
        {
            if (vrxParser1?.VehicleReport != null && vrxParser2?.VehicleReport != null)
            {
                var component1 = vrxParser1?.VehicleReport.ComponentList.FirstOrDefault(x => x.ECUShortName == ecuName && x.CommunicationState == 6);
                var component2 = vrxParser2?.VehicleReport.ComponentList.FirstOrDefault(x => x.ECUShortName == ecuName && x.CommunicationState == 6);

                if (component1 != null && component2 == null)
                {
                    return Color.Blue;
                }

                if (component1 == null && component2 != null)
                {
                    return Color.Brown;
                }



                return Color.Green;
            }
            else
                return Color.Black;
        }

        private bool ContainsNode(TreeNodeCollection collection, string name)
        {
            foreach (TreeNode node in collection)
            {
                if(node.Text == name)
                    return true;
            }
            return false;
        }
    }
}
