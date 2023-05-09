using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Final_Project_WinForm
{
    public class LinkedList_SinhVien
    {
        public SingleNode<SinhVien> head;

        public LinkedList_SinhVien()
        {
            head = null;
        }

        public void AddFirst(SinhVien data)
        {
            SingleNode<SinhVien> newNode = new SingleNode<SinhVien>(data);
            newNode.next = head;
            head = newNode;
        }

        public void AddLast(SinhVien data)
        {
            SingleNode<SinhVien> newNode = new SingleNode<SinhVien>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                SingleNode<SinhVien> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }
        public void Add_MonHoc(string maMH, string LanThi)
        {
            SingleNode<SinhVien> current = head;

            while(current != null)
            {
                current.data.DSDiem.AddLast(new Diem(maMH, int.Parse(LanThi),0));
                current = current.next;
            }
        }
        public void Remove_MonHoc(string maMH, string LanThi)
        {
            SingleNode<SinhVien> current = head;

            while (current != null)
            {
                current.data.DSDiem.Remove(new Diem(maMH, int.Parse(LanThi), 0));
                current = current.next;
            }
        }
        public void Update(SinhVien updatedData,SingleNode<SinhVien>data)
        {
            SingleNode<SinhVien> current = head;

            while (current != null)
            {
                if (current == data)
                {
                    current.data = updatedData;
                    break;
                }
                current = current.next;
            }
        }
        public SingleNode<SinhVien> Search(int mssv)
        {
            SingleNode<SinhVien> current = head;
            while(current!=null)
            {
                if (current.data.MASV == mssv)
                    break;
                current = current.next;
            }
            return current;
        }
       
        public void getlistMonhoc(ListView listview_dsDiem,string mamonhoc, int lanthi,string mssv_upDiem, int diem)
        {
            string check= Nhap_MonHoc.DS_MonHoc.Find_MonHoc_by_MaMH(mamonhoc);
            if (check == null)
            {
                MessageBox.Show("Úi không có Mã môn học hoặc lần thi này bạn ơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SingleNode<SinhVien> current = head;
                int STT = 1;
                while (current != null)
                {
                    if (mssv_upDiem == null)
                        current.data.DSDiem.getDiemmonhoc(listview_dsDiem, current.data.TEN, current.data.HO, current.data.MASV, mamonhoc, lanthi, diem, STT);
                    else if (current.data.MASV == int.Parse(mssv_upDiem))
                    {
                        current.data.DSDiem.getDiemmonhoc(listview_dsDiem, current.data.TEN, current.data.HO, current.data.MASV, mamonhoc, lanthi, diem, STT);
                        break;
                    }

                    current = current.next;
                    STT++;
                }
            }
        }
    
        public void Bangdiemtongket(ListView lv_bang_TK,BST bst)
        {

            SingleNode<SinhVien> current = head;
            int STT = 0;
            List<MonHoc> listMonhoc = bst.getDSMonHoc();

               foreach (MonHoc monhoc in listMonhoc)
            {
                //Console.Write(monhoc.MAMH + "\t" + "||");
                lv_bang_TK.Columns.Add(monhoc.MAMH);
            }
   

            while (current != null)
            {
                //Console.Write("\t" + i + "\t" + "||" + "\t" + current.data.MASV + "\t" + "||" + "\t" + current.data.HO + " " + current.data.TEN + "\t" + "||" + "\t");
                ListViewItem lvi = new ListViewItem((STT+1).ToString());
                lvi.SubItems.Add(current.data.MASV.ToString());
                lvi.SubItems.Add(current.data.HO +" "+ current.data.TEN);
                
                current.data.DSDiem.getTongKetKhoaHoc(current.data.TEN, current.data.HO, current.data.MASV, bst,lvi);
                
                lv_bang_TK.Items.Add(lvi);
                STT++;
                current = current.next;
            }
        }
        public void diemtrungbinh(ListView lvi_Diem_Tb,BST bst)
        {

            SingleNode<SinhVien> current = head;
            int i = 1;
            while (current != null)
            {
                double diemtrungbinhkhoahoc = current.data.DSDiem.getDiemtrungbinhkhoahoc(bst);

       
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(current.data.MASV.ToString());
                lvi.SubItems.Add(current.data.HO);
                lvi.SubItems.Add(current.data.TEN);
                lvi.SubItems.Add(diemtrungbinhkhoahoc.ToString());
                lvi_Diem_Tb.Items.Add(lvi);


                i++;
                current = current.next;
            }
        }



        public void Remove(SingleNode<SinhVien> data)
        {
            SingleNode<SinhVien> current = head;

            while (current != null)
            {
                if (current == data)
                {
                    head = current.next;
                }
                else
                if (current.next == data)
                {
                    current.next = current.next.next;
                }
                current = current.next;
            }
        }

        public void SortList()
        {
            if (head == null || head.next == null)
                return;

            bool isSwapped = true;

            while (isSwapped)
            {
                isSwapped = false;
                SingleNode<SinhVien> current = head;

                while (current.next != null)
                {
                    if (string.Compare(current.data.TEN, current.next.data.TEN) > 0)
                    {
                        SinhVien temp = current.data;
                        current.data = current.next.data;
                        current.next.data = temp;
                        isSwapped = true;
                    }

                    current = current.next;
                }
            }
        }
        public void Traverse(ListView listview)
        {
            if (head == null)
                return;
            SingleNode<SinhVien> current = head;
            while (current != null)
            {
                SortList();
                ListViewItem item = new ListViewItem();
                item.Text = current.data.MASV.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = current.data.HO });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = current.data.TEN });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = current.data.PHAI });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = current.data.SODT.ToString() });
                listview.Items.Add(item); 

                current = current.next;

            }
        }
    }
}
