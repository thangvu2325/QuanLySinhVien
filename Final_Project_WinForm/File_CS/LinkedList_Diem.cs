using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Final_Project_WinForm
{
    public class LinkedList_Diem
    {
        public SingleNode<Diem> head;

        public LinkedList_Diem()
        {
            head = null;
        }

        public void AddFirst(Diem data)
        {
            SingleNode<Diem> newNode = new SingleNode<Diem>(data);
            newNode.next = head;
            head = newNode;
        }

        public void AddLast(Diem data)
        {
            SingleNode<Diem> newNode = new SingleNode<Diem>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                SingleNode<Diem> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }
        public void editDiem(Diem diemEdit, int diem)
        {
            diemEdit.DIEM = diem;

        }
        public void getTongKetKhoaHoc(string ten, string ho, int mssv, BST bst,ListViewItem lv_Diem)
        {
            SingleNode<Diem> current = head;
            int i = 1;
            List<Diem> myList = new List<Diem>();
            List<MonHoc> listMonhoc = bst.getDSMonHoc();
            bool check = false;
            int k = 3;
            while (current != null)
            {
                bool add = true;

                  for (int j = 0; j < myList.Count; j++)
                {
                    if (current.data.MAMH == myList[j].MAMH)
                    {
                        if (current.data.DIEM > myList[j].DIEM)
                        {
                            myList[j].DIEM = current.data.DIEM;
                        }
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    myList.Add(current.data);
                }

                current = current.next;
            }

            foreach (MonHoc monhoc in listMonhoc)
            {
                foreach (Diem diem in myList)
                {
                    
                    if (diem.MAMH == monhoc.MAMH)
                    {
                        //Console.Write(diem.DIEM + "\t" + "||");
                        lv_Diem.SubItems.Add(diem.DIEM.ToString());
                        check = false;
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                    k++;
                }
                if (check)
                {
                    lv_Diem.SubItems.Add("0");
                    check = false;
                }

            }
            //Console.WriteLine();

        }
        public double getDiemtrungbinhkhoahoc(BST bst)
        {
            SingleNode<Diem> current = head;
            List<MonHoc> listMonhoc = bst.getDSMonHoc();
            int i = 0;
            double s = 0;
            int sotinchi = 0;
            while (current != null)
            {
                foreach (MonHoc monhoc in listMonhoc)
                {
                    if (monhoc.MAMH == current.data.MAMH)
                    {
                        sotinchi = monhoc.STCLT;
                        break;
                    }
                }
                s += current.data.DIEM * sotinchi;
                i += sotinchi;
                current = current.next;
            }
            double trungbinh = 0;
            if (i != 0)
            {
                trungbinh = (double)s / i;
            }
            return trungbinh;

        }
        public void getDiemmonhoc(ListView lv_dsDiem, string ten, string ho, int masv, string mamonhoc, int lanthi, int diem,int stt)
        {
            SingleNode<Diem> current = head;
           
            while (current != null)
            {
               
                if (diem!=0 && current.data.MAMH == mamonhoc && current.data.LAN == lanthi)
                {
                    editDiem(current.data, diem);
                }

                else if(diem == 0 && current.data.MAMH == mamonhoc && current.data.LAN == lanthi)
                {
                   
                    if (current.data.DIEM == 0)
                    {
                        ListViewItem lvi = new ListViewItem(stt.ToString());
                        lvi.SubItems.Add(masv.ToString());
                        lvi.SubItems.Add(ho);
                        lvi.SubItems.Add(ten);
                        lvi.SubItems.Add("");
                        lv_dsDiem.Items.Add(lvi);
                    }
                    else
                    {

                        ListViewItem lvi = new ListViewItem(stt.ToString());
                        lvi.SubItems.Add(masv.ToString());
                        lvi.SubItems.Add(ho);
                        lvi.SubItems.Add(ten);
                        lvi.SubItems.Add(current.data.DIEM.ToString());
                        lv_dsDiem.Items.Add(lvi);
                    }
                }

                current = current.next;
                
            }
           
        }
        public void Remove(Diem data)
        {
            SingleNode<Diem> current = head;
            SingleNode<Diem> previous = null;

            while (current != null)
            {
                if (current.data == data)
                {
                    if (previous == null)
                    {
                        head = current.next;
                    }
                    else
                    {
                        previous.next = current.next;
                    }
                    break;
                }
                previous = current;
                current = current.next;
            }
        }

        public void Traverse()
        {
            SingleNode<Diem> current = head;
            while (current != null)
            {
                Console.WriteLine("\t \t " + " | " + current.data.MAMH + " | " + current.data.LAN + " | " + current.data.DIEM + " | ");
                current = current.next;
            }
        }
    }
}
