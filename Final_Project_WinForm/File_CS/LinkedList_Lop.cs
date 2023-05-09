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
    public class LinkedList_Lop 
    {
        
        public SingleNode<Lop> head;
        public ObjectId Id { get; set; }

        private int size;

        public LinkedList_Lop()
        {
            head = null;
            size = 0;
        }
        public int length()
        {
            return size;
        }

        public void AddFirst(Lop data)
        {
            SingleNode<Lop> newNode = new SingleNode<Lop>(data);
            newNode.next = head;
            head = newNode;
        }

        public void AddLast(Lop data)
        {
            SingleNode<Lop> newNode = new SingleNode<Lop>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                SingleNode<Lop> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            size = size + 1;
        }


        public void Remove(SingleNode<Lop> lop)
        {
            SingleNode<Lop> current = head;

            while (current != null)
            {
                if (current == lop)
                {
                    head = current.next;
                }
                else
                if (current.next == lop)
                {
                    current.next = current.next.next;
                }
                current = current.next;
            }
        }
        public void Update(Lop updatedData,SingleNode<Lop> node)
        {
            if (node == null)
            {
                // Nút được truyền vào không tồn tại
                return;
            }

            SingleNode<Lop> current = head;

            while (current != null)
            {
                if (current == node)
                {
                    current.data= updatedData;
                    break;
                }
                current = current.next;
            }
        }
        public SingleNode<Lop> Search(string malop)
        {
            SingleNode<Lop> current = head;
            while(current != null)
            {
                if (current.data.MALOP == malop)
                    break;
                current = current.next;
            }
            return current;
        }
        public void Nhaphocsinh(string masolop, SinhVien newSinhvien)
        {
            SingleNode<Lop> current = head;

            while (current != null)
            {
                if (current.data.MALOP == masolop)
                {
                    current.data.DSSV.AddFirst(newSinhvien);
                    break;
                }
                current = current.next;
            }

        }

        public void getSinhvien(ListView Listview_dsDiem,string masolop, string mamonhoc, int lanthi, string mssv_updiem=null, int diem = 0 )
        {
            SingleNode<Lop> current = head;

            while (current != null)
            {
                if (current.data.MALOP == masolop)
                {
                    current.data.DSSV.getlistMonhoc(Listview_dsDiem ,mamonhoc, lanthi,mssv_updiem, diem);
                    
                   
                    break;
                }
                current = current.next;
            }

        }

        public void getAverageScoreInClass( ListView liv_Diem_TB,string masolop, BST bst, bool bangtongket = false)
        {
            SingleNode<Lop> current = head;

            while (current != null)
            {
                if (current.data.MALOP == masolop)
                {
                    if (bangtongket)
                    {
                        current.data.DSSV.Bangdiemtongket(liv_Diem_TB,bst);
                    }
                    else
                    {
                        current.data.DSSV.diemtrungbinh(liv_Diem_TB,bst);
                    }
                }

                current = current.next;
            }


        }
        public string Nam_Hoc_form_MaLop(string Malop)
        {
            SingleNode<Lop> node = Find_Lop(Malop);
            return node.data.NAMNHAPHOC.ToString();

        }
        public string Ten_Lop_from_MaLop(string Malop)
        {
            SingleNode<Lop> node = Find_Lop(Malop);
            return node.data.TENLOP;

        }
        public SingleNode<Lop> Find_Lop(string maLop)
        {
            SingleNode<Lop> current_ds_Lop = head;
            while (current_ds_Lop != null)
            {
                if (current_ds_Lop.data.MALOP ==maLop)
                    break;
                current_ds_Lop = current_ds_Lop.next;
            }
            return current_ds_Lop;
        }
        public void Traverse(ListView listView,int nienkhoa = 0)
        {
            SingleNode<Lop> current = head;
            while (current != null)
            {
                if (nienkhoa == 0)
                {
                    // Console.WriteLine(" | " + current.data.MALOP + " | " + current.data.TENLOP + " | " + current.data.NAMNHAPHOC + " | ");
                    ListViewItem item = new ListViewItem();
                    item.Text = current.data.MALOP;
                    listView.Items.Add(item);
                    ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, current.data.TENLOP);
                    ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, current.data.NAMNHAPHOC.ToString());
                    item.SubItems.Add(subitem1);
                    item.SubItems.Add(subitem2);
                   
                }
                else if (current.data.NAMNHAPHOC == nienkhoa)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = current.data.MALOP;
                    listView.Items.Add(item);
                    ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, current.data.TENLOP);
                    ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, current.data.NAMNHAPHOC.ToString());
                    item.SubItems.Add(subitem1);
                    item.SubItems.Add(subitem2);
                }

                current = current.next;
            }
        }


    }
}
