using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Деревья_2
{
    class TreeNode
    {
        public int node_Value { get; set; }
        public TreeNode node_Left;
        public TreeNode node_Right;
        public int x { get; set; }
        public int y { get; set; }


        public TreeNode(TreeNode Left, TreeNode Right, int Value, int x, int y) //конструктор
        {
            node_Left = Left;
            node_Right = Right;
            node_Value = Value;
            this.x = x;
            this.y = y;
        }
    }

    class Tree
    {
        private static Random rnd = new Random();

        public TreeNode tree_root = null;
        public Bitmap tree_Canvas { get; set; }
        public TreeNode NodeSelect { get; set; }
        
        Graphics _Graph;
        Pen _Pen;
        SolidBrush _Brush = (SolidBrush)Brushes.White;
        Font _Font;

        public Tree(int Vweight, int Vheight) //конструктор
        {
            tree_root = null;
            tree_Canvas = new Bitmap(Vweight, Vheight);
            _Font = new Font("Courier New", 10, FontStyle.Bold);
        }

        public TreeNode max;

        public int MaxSubtreeResult(int k)
        {
            //max = null;
            return MaxSubtree1(tree_root, k).node_Value;
        }

        private TreeNode MaxSubtree1(TreeNode p, int level)
        {
            if (p == null) return null;
            TreeNode max1, max2;
            if (level == 1)
                return p;
            max1 = MaxSubtree1(p.node_Left, level - 1);
            max2 = MaxSubtree1(p.node_Right, level - 1);
            if (max1 == null) return max2;
            else if (max2 == null) return max1;
            else if (max1.node_Value > max2.node_Value) return max1;
            else return max2;
        }

        void DrawNode(TreeNode p)               // рисование узла дерева (рекурсивно)
        {
            int R = 17;
            if (p.node_Left != null)
                _Graph.DrawLine(_Pen, p.x, p.y, p.node_Left.x, p.node_Left.y);
            if (p.node_Right != null)
                _Graph.DrawLine(_Pen, p.x, p.y, p.node_Right.x, p.node_Right.y);

            _Brush = (SolidBrush)Brushes.Aquamarine;

            _Graph.FillEllipse(_Brush, p.x - R, p.y - R, 2 * R, 2 * R);
            _Graph.DrawEllipse(_Pen, p.x - R, p.y - R, 2 * R, 2 * R);
            string s = Convert.ToString(p.node_Value);
            SizeF size = _Graph.MeasureString(s, _Font);
            _Graph.DrawString(s, _Font, Brushes.Black,
                p.x - size.Width / 2,
                p.y - size.Height / 2);

            if (p.node_Left != null)
                DrawNode(p.node_Left);
            if (p.node_Right != null)
                DrawNode(p.node_Right);
        }

        public void Draw()                  // рисование дерева
        {
            using (_Graph = Graphics.FromImage(tree_Canvas))
            {
                Color cl = Color.FromArgb(255, 255, 255);
                _Graph.Clear(cl);
                _Pen = Pens.Black;
                if (tree_root != null)
                    DrawNode(tree_root);
            }
        }

        public void Insert(ref TreeNode top, int val, int x, int y, int dx = 128) //вставка
        {
            if (top == null)
                top = new TreeNode(null, null, val, x, y);
            else
                if (top.node_Left != null)
                Insert(ref top.node_Right, val, top.x + dx, top.y + 50, dx / 2);
            else Insert(ref top.node_Left, val, top.x - dx, top.y + 50, dx / 2);
        }
    }
}
