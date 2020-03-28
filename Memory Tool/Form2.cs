using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Memory_Tool
{
    public partial class Form2 : Form
    {
        Form1 f1;

        public delegate bool EnumWindowCallback(int hwnd, int lParam);

        [DllImport("user32.dll")]
        public static extern int EnumWindows(EnumWindowCallback callback, int y);

        [DllImport("user32.dll")]
        public static extern int GetParent(int hWnd);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        public static extern long GetWindowLong(int hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern IntPtr GetClassLong(IntPtr hwnd, int nIndex);

        [DllImport("user32")]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        const int GCL_HICON = -14; //GetWindowLong을 호출할 때 쓸 인자

        const int GCL_HMODULE = -16;

        ImageList imgList;//ListView의 Image로 쓸 리스트

        public Form2(Form1 form)
        {
            InitializeComponent();
            f1 = form;
            imgList = new ImageList();
            imgList.ImageSize = new Size(16, 16);
            listView1.SmallImageList = imgList;
            listView1.View = View.List;
            //CallBack 델리게이트 생성
            EnumWindowCallback callback = new EnumWindowCallback(EnumWindowsProc);
            EnumWindows(callback, 0);
        }
        public bool EnumWindowsProc(int hWnd, int lParam)
        {
            //윈도우 핸들로 그 윈도우의 스타일을 얻어옴
            UInt32 style = (UInt32)GetWindowLong(hWnd, GCL_HMODULE);
            //해당 윈도우의 캡션이 존재하는지 확인
            if ((style & 0x10000000L) == 0x10000000L && (style & 0x00C00000L) == 0x00C00000L)
            {
                //부모가 바탕화면인지 확인
                if (GetParent(hWnd) == 0)
                {
                    StringBuilder Buf = new StringBuilder(256);
                    //응용프로그램의 이름을 얻어온다
                    if (GetWindowText(hWnd, Buf, 256) > 0)
                    {
                        try
                        {
                            //HICON 아이콘 핸들을 얻어온다
                            IntPtr hIcon = GetClassLong((IntPtr)hWnd, GCL_HICON);
                            //아이콘 핸들로 Icon 객체를 만든다
                            Icon icon = Icon.FromHandle(hIcon);
                            imgList.Images.Add(icon);
                        }
                        catch (Exception)
                        {
                            //예외의 경우는 자기 자신의 윈도우인 경우이다.
                            imgList.Images.Add(this.Icon);
                        }
                        listView1.Items.Add(new ListViewItem(Buf.ToString(), listView1.Items.Count));
                    }
                }
            }
            return true;
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem lvItem = items[0];
                string add = lvItem.SubItems[0].Text;
                Form1.processHandle = FindWindow(null, add);
                GetWindowThreadProcessId(Form1.processHandle, out Form1.procid);
                Form1.processHandle = Form1.OpenProcess(Form1.PROCESS_ALL_ACCESS, false, new IntPtr(Form1.procid));
                f1.labelpid.Text = Form1.procid.ToString();
                //프로세스아이디명
                f1.labelpid.Width = f1.labelpid.Text.Length * 7;
                f1.labelpid.Left = f1.Width / 2 - f1.labelpid.Width / 2;
                f1.labelpid.Visible = true;
                //핸들명
                f1.labelhandle.Text = Form1.processHandle.ToString();
                f1.labelhandle.Width = f1.labelhandle.Text.Length * 7;
                f1.labelhandle.Left = f1.Width / 2 - f1.labelhandle.Width / 2;
                f1.labelhandle.Visible = true;
                //프로세스명
                f1.labelprocessname.Text = add;
                f1.labelprocessname.Width = add.Length * 7;
                f1.labelprocessname.Left = f1.Width / 2 - f1.labelprocessname.Width / 2;
            }
            this.Close();
        }
    }
}
