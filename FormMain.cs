using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Деревья_2
{
    public partial class FormMain : Form
    {
        int[] Arr;
        Random _rnd = new Random();
        Graphics Graph;
        Tree Tree;

        public FormMain()
        {
            InitializeComponent();
            Graph = panel.CreateGraphics();
            Tree = new Tree(panel.Width, panel.Height);
        }

        public void MyDraw()
        {
            Tree.Draw();
            Graph.DrawImage(Tree.tree_Canvas, 0, 0);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateTree_Click(object sender, EventArgs e)
        {
            int leng = int.Parse(nUDNumberTreeElements.Value.ToString());
            Arr = new int[leng + 1];
            Graph.Clear(Color.White);
            Tree = new Tree(panel.Width, panel.Height);

            for (int i = 0; i < leng; i++)
            {
                int k = _rnd.Next(0, 100);
                Tree.Insert(ref Tree.tree_root, k, panel.Width / 2, 40, panel.Width / 4);
            }
            MyDraw();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            tBResult.Text = Tree.MaxSubtreeResult(Convert.ToInt32(tBLevelK.Text)).ToString();
        }
    }
}
