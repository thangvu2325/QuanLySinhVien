using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Final_Project_WinForm
{
    public class BST
    {
        public TreeNode root;
        public ObjectId Id { get; set; }

        public BST()
        {
            root = null;
        }

        public void Insert(MonHoc data)
        {
            root = InsertRec(root, data);
        }
        private TreeNode InsertRec(TreeNode root, MonHoc data)
        {
            if(root == null)
            {
                root = new TreeNode(data);
            }
            else if(String.Compare(data.TENMH, root.Data.TENMH) < 0)
                root.left = InsertRec(root.left, data);
            else 
                root.right = InsertRec(root.right, data);

            return root;
        }

        public List<MonHoc> getDSMonHoc()
        {
            List<MonHoc> myList = new List<MonHoc>();

            return getDSMonHocRec(myList, root);
        }
        public List<MonHoc> getDSMonHocRec(List<MonHoc> myList, TreeNode root)
        {
            if (root != null)
            {
                myList.Add(root.Data);
                getDSMonHocRec(myList, root.left);
                getDSMonHocRec(myList, root.right);
            }
            return myList;
        }


        public void Inorder(ListView listview)
        {
            InorderRec(root,listview);
        }

        private void InorderRec(TreeNode root,ListView listview)
        {
            if (root != null)
            {
                InorderRec(root.left ,listview);
                //Console.WriteLine("\t" + " | " + root.Data.MAMH + " | " + root.Data.TENMH + " | ");
                ListViewItem item = new ListViewItem();
                item.Text = root.Data.MAMH;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = root.Data.TENMH });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = root.Data.STCLT.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = root.Data.STCTH.ToString() });
                listview.Items.Add(item);
                InorderRec(root.right,listview);
            }
        }
        public void Preorder()
        {
            PreorderRec(root);
        }

        private void PreorderRec(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine("\t" + " | " + root.Data.MAMH + " | " + root.Data.TENMH + " | ");
                PreorderRec(root.left);
                PreorderRec(root.right);
            }
        }
        public void Postorder()
        {
            PostorderRec(root);
        }
        private void PostorderRec(TreeNode root)
        {
            if (root != null)
            {
                PostorderRec(root.left);
                PostorderRec(root.right);
                Console.WriteLine("\t" + " | " + root.Data.MAMH + " | " + root.Data.TENMH + " | ");
            }
        }
        public TreeNode Search(string tenMH)
        {
            return SearchRec(root,tenMH);
        }

        private TreeNode SearchRec(TreeNode root,string ten_mh)
        {
            if (root == null || root.Data.TENMH == ten_mh)
            {
                return root;
            }

            else if (string.Compare(ten_mh, root.Data.TENMH) < 0)
            {
                return SearchRec(root.left, ten_mh);
            }
            else
            return SearchRec(root.right, ten_mh);
        }

        public string Find_MonHoc_by_MaMH(string maMH)
        {
            string ten_monHoc=null;
            List<MonHoc> ds_MonHoc = getDSMonHoc();
            foreach(MonHoc i in ds_MonHoc)
            {
                if(i.MAMH == maMH)
                {
                    ten_monHoc = i.TENMH;
                    break;
                }
            }
            return ten_monHoc;
        }

        /*private TreeNode Find_MaMH(TreeNode root, string maMH)
        {
            if (root == null || root.Data.MAMH.Equals(maMH))
            {
                return root;
            }

            else if (string.Compare(maMH, root.Data.MAMH) < 0)
            {
                return Find_MaMH(root.left, maMH);
            }
            else
                return Find_MaMH(root.right, maMH);
        }
*/
        public void Delete(MonHoc Data)
        {
            root = DeleteRec(root, Data);
        }

        private TreeNode DeleteRec(TreeNode root, MonHoc Data)
        {
            if (root == null)
            {
                return root;
            }

            if (string.Compare(Data.TENMH, root.Data.TENMH) < 0)
            {
                root.right = DeleteRec(root.right, Data);
            }
            else if (string.Compare(Data.TENMH, root.Data.TENMH) > 0)
            {
                root.left = DeleteRec(root.left, Data);
            }
            else
            {
                if (root.left == null)
                {
                    return root.right;
                }
                else if (root.right == null)
                {
                    return root.left;
                }

                root.Data = MinValue(root.right);

                root.right = DeleteRec(root.right, root.Data);
            }

            return root;
        }

        private MonHoc MinValue(TreeNode root)
        {
            MonHoc minv = root.Data;

            while (root.left != null)
            {
                minv = root.left.Data;
                root = root.left;
            }

            return minv;
        }

    } 
}
