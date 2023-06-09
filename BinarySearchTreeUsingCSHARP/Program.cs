namespace BinarySearchTreeUsingCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Binary Search Tree Implementation\n");
            CustomBinarySearchTree CustomBst = new CustomBinarySearchTree();
            CustomBst.Add(35);
            CustomBst.Add(27);
            CustomBst.Add(56);
            CustomBst.Add(62);
            CustomBst.Add(91);
            CustomBst.Add(28);
            CustomBst.Add(93);
            CustomBst.Add(16);

            //int x = 26;
            //Console.Write(CustomBst.Search(x));
            //if (CustomBst.Search(x))
            //{
            //    Console.WriteLine("\nThe Given Number " + x + " Is Present In Binary Search Tree\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nThe Given Number " + x + " Is Not Present In Binary Search Tree\n");
            //}

            //Console.Write("\nPreorder Traversal : \n");
            //CustomBst.PreorderDisplay(CustomBst.ReturnRoot());

            Console.Write("\nInorder traversal of tree is :\n");
            CustomBst.InorderDisplay(CustomBst.ReturnRoot());

            Console.Write("\nPost Order Traversal Of tree is :\n");
            CustomBst.PostorderDisplay(CustomBst.ReturnRoot());
        }
    }
}