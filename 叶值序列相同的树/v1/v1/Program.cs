using System.Collections.Generic;

namespace v1
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> leaf1 = new List<int>();
            List<int> leaf2 = new List<int>();
            GetLeaf(root1, leaf1);
            GetLeaf(root2, leaf2);

            if (leaf1.Count != leaf2.Count)
                return false;

            for (int i = 0; i < leaf1.Count; i++)
            {
                if (leaf1[i] != leaf2[i])
                    return false;
            }
            return true;
        }

        public void GetLeaf(TreeNode p, List<int> list)
        {
            if (p == null)
                return;

            if (p.left == null && p.right == null)
                list.Add(p.val);

            if (p.left != null)
            {
                GetLeaf(p.left, list);
            }

            if (p.right != null)
            {
                GetLeaf(p.right, list);
            }
        }
    }
}
