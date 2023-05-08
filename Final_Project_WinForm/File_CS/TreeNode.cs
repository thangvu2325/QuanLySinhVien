using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm
{
    public class TreeNode
    {
        public MonHoc Data { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public TreeNode(MonHoc data)
        {
            Data = data;
            left = null;
            right = null;
        }
    }
}
