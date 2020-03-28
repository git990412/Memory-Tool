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
using System.Threading;

namespace Memory_Tool
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        public static extern IntPtr OpenProcess(Int32 Access, Boolean InheritHandle, IntPtr ProcessId); //오픈프로세스

        [DllImport("kernel32")]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out uint nNumberOfBytesWritten); //라이트프로세스메모리

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr pHandle, IntPtr Address, byte[] Buffer, int Size, IntPtr NumberofBytesRead);

        byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        void showmemory()
        {
            while (true)
            {
                if (textboxreadparm.Text.Length > 0)
                {
                    try
                    {
                        //Show 4byte to hex
                        ReadProcessMemory(processHandle, (IntPtr)Convert.ToInt32(textboxreadparm.Text, 16), readbuffer, readbuffer.Length, bytesread);
                        if (BitConverter.IsLittleEndian)
                            Array.Reverse(readbuffer);
                        int bytetoint = BitConverter.ToInt32(readbuffer, 0);
                        textboxshowadress.Text = bytetoint.ToString("X2");
                        //Show 4byte to int
                        textboxShow4bytetoint.Text = bytetoint.ToString();
                        //show 1byte to int
                        byte byte1 = readbuffer[3];
                        int intbyte1 = byte1;
                        textBoxShow1Bytetoint.Text = intbyte1.ToString();
                        //show 2byte to int
                        byte byte2 = readbuffer[2];
                        int intbyte2 = byte2;
                        textBoxShow2Bytetoint.Text = intbyte2.ToString();
                        //show 3byte to int
                        byte byte3 = readbuffer[1];
                        int intbyte3 = byte3;
                        textBoxShow3Bytetoint.Text = intbyte3.ToString();
                        //show 4byte to int
                        byte byte4 = readbuffer[0];
                        int intbyte4 = byte4;
                        textBoxShow5Bytetoint.Text = intbyte4.ToString();
                        //show dword to float
                        Array.Reverse(readbuffer);
                        float Dwordshowfloat = BitConverter.ToSingle(readbuffer, 0);
                        textboxShowfloat.Text = Dwordshowfloat.ToString();
                        //labelchange
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {

                    }
                }
                else
                {
                    textboxshowadress.Text = "";
                    textboxShow4bytetoint.Text = "";
                    textBoxShow1Bytetoint.Text = "";
                    textBoxShow2Bytetoint.Text = "";
                    textBoxShow3Bytetoint.Text = "";
                    textBoxShow5Bytetoint.Text = "";
                    textboxShowfloat.Text = "";
                }
                Thread.Sleep(1);
            }
        }

        void writeduringbuttonclick()
        {
            while (true)
            {
                try
                {
                    //Dwordwrite
                    if (Dwordwrite.Text.Length > 0)
                    {
                        byte[] dwordbuffer = StringToByteArray(Dwordwrite.Text);
                        WriteProcessMemory(processHandle, (IntPtr)Convert.ToInt32(textboxreadparm.Text, 16), dwordbuffer, dwordbuffer.Length, out written);
                    }
                    //Floatwrite
                    if (writefloattextbox.Text.Length > 0)
                    {
                        float floatbuffer = float.Parse(writefloattextbox.Text);
                        byte[] FloatToByte = System.BitConverter.GetBytes(floatbuffer);
                        WriteProcessMemory(processHandle, (IntPtr)Convert.ToInt32(textboxreadparm.Text, 16), FloatToByte, FloatToByte.Length, out written);
                    }
                    if (writeinttextbox.TextLength > 0)
                    {
                        int i = Int32.Parse(writeinttextbox.Text);
                        byte[] intBytes = BitConverter.GetBytes(i);
                        WriteProcessMemory(processHandle, (IntPtr)Convert.ToInt32(textboxreadparm.Text, 16), intBytes, intBytes.Length, out written);
                    }
                }
                catch (Exception)
                {

                }
                Thread.Sleep(1);
            }
        }

        public static int PROCESS_ALL_ACCESS = 0x1F0FFF; //오픈프로세스인자
        public static IntPtr processHandle; //핸들
        public static uint written; //writeprocessmemory 인자
        public static uint procid; //프로세스id
        byte[] readbuffer = new byte[4];
        IntPtr bytesread;
        Thread t1;
        bool writebutton = false;
        Thread writeduring;

        public Form1(IntPtr pram_handle, uint pram_procid)
        {
            InitializeComponent();
            procid = pram_procid;
            processHandle = pram_handle;
        }

        private void button1_Click(object sender, EventArgs e)  //Process List 버튼
        {
            Form2 dlg = new Form2(this);
            dlg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            t1 = new Thread(new ThreadStart(showmemory));
            t1.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
            t1.Join();
            if (writebutton == true)
            {
                writeduring.Abort();
                writeduring.Join();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (writebutton == false)
            {
                writebutton = true;
                button3.Text = "■";
                writeduring = new Thread(new ThreadStart(writeduringbuttonclick));
                writeduring.Start();
            }
            else
            {
                writeduring.Abort();
                writeduring.Join();
                writebutton = false;
                button3.Text = "∞";
            }
        }

        private void writeinttextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textboxreadparm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자, 16진수만 입력되도록 필터링
            if (!(e.KeyChar >= 'a' && e.KeyChar <= 'f') && (char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b') && (e.KeyChar != '') && (e.KeyChar != ''))
            {
                e.Handled = true;
            }
        }

        private void Dwordwrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자, 16진수만 입력되도록 필터링
            if (!(e.KeyChar >= 'a' && e.KeyChar <= 'f') && (char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b') && (e.KeyChar != '') && (e.KeyChar != ''))
            {
                e.Handled = true;
            }
        }

        private void writefloattextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //실수만 입력받기
            int keyCode = (int)e.KeyChar;
            //46은 점 ( . ) 
            if ((keyCode < 48 || keyCode > 57) && keyCode != 8 && keyCode != 46)
            {
                e.Handled = true;
            }
            if (keyCode == 46)
            {
                //null 일경우 || 이미 .이 있는경우
                if (string.IsNullOrEmpty(this.writefloattextbox.Text) || this.writefloattextbox.Text.Contains('.') == true)
                {
                    e.Handled = true;
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 readform = new Form1(processHandle, procid);
            readform.Text = "Another Form";
            //라벨pid
            readform.labelpid.Text = labelpid.Text;
            readform.labelpid.Width = labelpid.Width;
            readform.labelpid.Left = labelpid.Left;
            readform.labelpid.Visible = labelpid.Visible;
            //labelhandle
            readform.labelhandle.Text = labelhandle.Text;
            readform.labelhandle.Width = labelhandle.Width;
            readform.labelhandle.Left = labelhandle.Left;
            readform.labelhandle.Visible = labelhandle.Visible;
            //labelprocessname
            readform.labelprocessname.Text = labelprocessname.Text;
            readform.labelprocessname.Width = labelprocessname.Width;
            readform.labelprocessname.Left = labelprocessname.Left;
            readform.labelprocessname.Visible = labelprocessname.Visible;
            readform.Show();
        }
    }
}
