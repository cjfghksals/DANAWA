using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace DANAWA
{
    public partial class Danawa : Form
    {
        static public string TransPrice = "";
        static public int PriceCPU = 0;//CPU의 가격
        static public int PriceSSD = 0;//SSD의 가격
        static public int PriceGPU = 0;//GPU의 가격
        static public int PriceMemory = 0;//램의 가격
        static public int PriceBoard = 0;//메인보드의 가격
        static public int PriceCase = 0;//케이스의 가격
        static public int PriceCooler = 0;//쿨러의 가격
        static public int PricePower = 0;//파워의 가격
        static public int TotalPriceCPU = 0;
        static public int TotalPriceSSD = 0;
        static public int TotalPriceGPU = 0;
        static public int TotalPriceMemory = 0;
        static public int TotalPriceBoard = 0;
        static public int TotalPriceCase = 0;
        static public int TotalPriceCooler = 0;
        static public int TotalPricePower = 0;
        public int TotalPrice = 0;



        public Danawa()
        {
            InitializeComponent();
        }
        public void TotalSum()
        {
            TotalPrice = PriceCPU * int.Parse(CountCPU.Text) + PriceCooler * int.Parse(CountCooler.Text) + PriceMemory * int.Parse(CountMemory.Text) + PriceBoard * int.Parse(CountMainBoard.Text) + PriceGPU * int.Parse(CountGPU.Text) + PriceSSD * int.Parse(CountSSD.Text) + PriceCase * int.Parse(CountCase.Text) + PricePower * int.Parse(CountPower.Text);
            ResultPrice.Text = TotalPrice.ToString("총 #,##0원");
        }
        private void Danawa_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 8;//빈 화면을 먼저 출력하기 위해 추가했다.
            //Geti9_14900K.Checked = false; //라디오 버튼을 false상태로 초기화
            //Geti7_14700K.Checked = false; //라디오 버튼을 false상태로 초기화
            //Get7900X3D.Checked = false;   //라디오 버튼을 false상태로 초기화
            //Get7800X3D.Checked = false;   //라디오 버튼을 false상태로 초기화
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //-------------------------------로그인버튼에 관한 코드 시작---------------------------------
        private void Login_Click(object sender, EventArgs e)//로그인 버튼이 눌리면 로그인 창을 연다.
        {
            LoginPage loginpage = new LoginPage(this);
            loginpage.ShowDialog();
        }
        //--------------------------------로그인에 관한 코드 끝-----------------------------------

        //---------------------------------CPU 상품 설명에 관한 코드 시작---------------------------
        private void Explaini9_14900K_MouseHover(object sender, EventArgs e)//i9-14900K의 설명에 마우스를 올리면 설명이 나온다.
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.Explaini9_14900K, "인텔(소켓1700) / 10nm(인텔7) / P8+E16코어 / 16+16쓰레드 / 기본 클럭:3.2GHz / 최대 클럭:6.0GHz \n/ L2 캐시:32MB / L3 캐시:36MB / PBP-MTP:125-253W / PCIe5.0, 4.0 / 메모리 규격:DDR5, DDR4 / 5600, 3200MHz /\n내장그래픽: 탑재 / 인텔 UHD 770 / 기술 지원:하이퍼스레딩 / 쿨러:미포함 / 시네벤치R23(싱글):2277 / 시네벤치R23(멀티):40146");
        }

        private void Explaini7_14700K_MouseHover(object sender, EventArgs e)//i7-14700K의 설명에 마우스를 올리면 설명이 나온다.
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.Explaini7_14700K, "인텔(소켓1700)/10nm(인텔7)/P8+E12코어/16+12쓰레드/기본 클럭:3.4GHz/최대 클럭:5.6GHz/\nL2 캐시:28MB/L3 캐시:33MB/PBP-MTP:125-253W/PCIe5.0, 4.0/메모리 규격:DDR5, DDR4/5600, 3200MHz/내장그래픽: 탑재\n/인텔 UHD 770/기술 지원:하이퍼스레딩/쿨러:미포함/시네벤치R23(싱글):2069/시네벤치R23(멀티):34818/출시가: 409달러 (VAT별도)");
        }

        private void Explain7900X3D_MouseHover(object sender, EventArgs e)//7900의 설명에 마우스를 올리면 설명이 나온다.
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.Explain7900X3D, "AMD(소켓AM5) / 5세대(Zen4) / 5nm / 12코어 / 24쓰레드 / 기본 클럭:4.4GHz / 최대 클럭:5.6GHz /\nL2 캐시:12MB / L3 캐시:128MB / TDP:120W / PPT:162W / PCIe5.0 / 메모리 규격:DDR5 / 5200MHz / 내장그래픽: 탑재 /\nAMD 라데온 그래픽 / 기술 지원:Ryzen Master;3D V캐시 / 쿨러:미포함");
        }

        private void Explain7800X3D_MouseHover(object sender, EventArgs e)//7800의 설명에 마우스를 올리면 설명이 나온다.
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.Explain7800X3D, "AMD(소켓AM5)/5세대(Zen4)/5nm/8코어/16쓰레드/기본 클럭:4.2GHz/최대 클럭:5.0GHz/\nL2 캐시:8MB/L3 캐시:96MB/TDP:120W/PPT:162W/PCIe5.0/메모리 규격:DDR5/5200MHz/내장그래픽: 탑재/\nAMD 라데온 그래픽/기술 지원:Ryzen Master,3D V캐시/쿨러:미포함/시네벤치R23(싱글):1820/시네벤치R23(멀티):18219/출시가: 449달러(VAT별도)");
        }

        //---------------------------------CPU 상품 설명에 관한 코드 끝-------------------------------------


        //----------------------------어떤 부품의 카트를 고를지 정하는 코드 시작-------------------------------------
        private void radioCPU_CheckedChanged(object sender, EventArgs e)//CPU카트를 눌렀을 때의 동작
        {
            if (radioCPU.Checked)
            {
                tabControl1.SelectedIndex = 0;
                radioCPU.BackColor = Color.Orange;
                //만약 카트가 비어다면 
                //Get체크 박스를 전부 false로 바꾸기
            }
            else
                radioCPU.BackColor = Color.Gray;
        }

        private void radioCooler_CheckedChanged(object sender, EventArgs e)//쿨러카트를 눌렀을 때의 동작
        {
            if (radioCooler.Checked)
            {
                tabControl1.SelectedIndex = 1;
                radioCooler.BackColor = Color.Orange;
            }
            else
                radioCooler.BackColor = Color.Gray;
        }

        private void radioMainBoard_CheckedChanged(object sender, EventArgs e)//메인보드카트를 눌렀을 때의 동작
        {
            if (radioMainBoard.Checked)
            {
                radioMainBoard.BackColor = Color.Orange;
                tabControl1.SelectedIndex = 2;
            }
            else
                radioMainBoard.BackColor = Color.Gray;
        }

        private void radioMemory_CheckedChanged(object sender, EventArgs e)//램카트를 눌렀을 때의 동작
        {
            if (radioMemory.Checked)
            {
                radioMemory.BackColor = Color.Orange;
                tabControl1.SelectedIndex = 3;
            }
            else
                radioMemory.BackColor = Color.Gray;
        }

        private void radioGPU_CheckedChanged(object sender, EventArgs e)//그래픽카드카트를 눌렀을 때의 동작
        {
            if (radioGPU.Checked)
            {
                radioGPU.BackColor = Color.Orange;
                tabControl1.SelectedIndex = 4;
            }
            else
                radioGPU.BackColor = Color.Gray;
        }

        private void radioSSD_CheckedChanged(object sender, EventArgs e)//SSD카트를 눌렀을 때의 동작
        {
            if (radioSSD.Checked)
            {
                radioSSD.BackColor = Color.Orange;
                tabControl1.SelectedIndex = 5;
            }
            else
                radioSSD.BackColor = Color.Gray;
        }

        private void radioCase_CheckedChanged(object sender, EventArgs e)//케이스카트를 눌렀을 때의 동작
        {
            if (radioCase.Checked)
            {
                radioCase.BackColor = Color.Orange;
                tabControl1.SelectedIndex = 6;
            }

            else
                radioCase.BackColor = Color.Gray;
        }

        private void radioPower_CheckedChanged(object sender, EventArgs e)//파워카트를 눌렀을 때의 동작
        {
            if (radioPower.Checked)
            {
                radioPower.BackColor = Color.Orange;
                tabControl1.SelectedIndex = 7;
            }

            else
                radioPower.BackColor = Color.Gray;
        }
        //----------------------------어떤 부품의 카트를 고를지 정하는 코드 끝-------------------------------------

        private void CountMainBoard_TextChanged(object sender, EventArgs e)
        {

        }

        //--------------------------------CPU상품을 카트에 담는 코드시작------------------------------------------
        int CPU_Cnt = 0;//CPU의 수량을 카운트한다.
        private void Geti9_14900K_CheckedChanged(object sender, EventArgs e)//14900K담기 버튼
        {
            int tempPrice = 855040;

            if (Geti9_14900K.BackColor == Color.Silver)
            {
                CPU_Cnt++;
                Geti9_14900K.BackColor = Color.Black;
                Geti9_14900K.ForeColor = Color.Silver;
                PlusCPU.Enabled = true;
                CountCPU.Enabled = true;
                MinusCPU.Enabled = true;
                //카트에 담긴 CPU의 이름과 가격을 해당 CPU의 이름과 가격으로 변경
                CPUCartName.Text = "인텔 i9-14900K";
                CountCPU.Text = (CPU_Cnt).ToString();
                PriceCPU = tempPrice;
                CPUCartPrice.Text = PriceCPU.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Geti9_14900K.BackColor = Color.Silver;
                Geti9_14900K.ForeColor = Color.Black;
                CPU_Cnt = 0;
                CountCPU.Text = CPU_Cnt.ToString();
                PlusCPU.Enabled = false;
                MinusCPU.Enabled = false;
                CountCPU.Enabled = false;
            }
        }

        private void Geti7_14700K_CheckedChanged(object sender, EventArgs e)//14700K담기 버튼
        {
            int tempPrice = 615090;
            if (Geti7_14700K.BackColor == Color.Silver)
            {
                CPU_Cnt++;
                Geti7_14700K.BackColor = Color.Black;
                Geti7_14700K.ForeColor = Color.Silver;
                PlusCPU.Enabled = true;
                CountCPU.Enabled = true;
                MinusCPU.Enabled = true;
                CPUCartName.Text = "인텔 i7-14700K";
                CountCPU.Text = (CPU_Cnt).ToString();
                PriceCPU = tempPrice;
                CPUCartPrice.Text = PriceCPU.ToString("#,##0원");
                TotalSum();


            }
            else
            {

                Geti7_14700K.BackColor = Color.Silver;
                Geti7_14700K.ForeColor = Color.Black;
                CPU_Cnt = 0;
                CountCPU.Text = CPU_Cnt.ToString();
                PlusCPU.Enabled = false;
                MinusCPU.Enabled = false;
                CountCPU.Enabled = false;
            }
        }

        private void Get7900X3D_CheckedChanged(object sender, EventArgs e)//7900X3D담기 버튼
        {
            int tempPrice = 675800;
            if (Get7900X3D.BackColor == Color.Silver)
            {
                CPU_Cnt++;
                Get7900X3D.BackColor = Color.Black;
                Get7900X3D.ForeColor = Color.Silver;
                PlusCPU.Enabled = true;
                CountCPU.Enabled = true;
                MinusCPU.Enabled = true;
                CPUCartName.Text = "AMD 라이젠9-5세대 7900X3D";
                CountCPU.Text = (CPU_Cnt).ToString();
                PriceCPU = tempPrice;
                CPUCartPrice.Text = PriceCPU.ToString("#,##0원");
                TotalSum();



            }
            else
            {

                Get7900X3D.BackColor = Color.Silver;
                Get7900X3D.ForeColor = Color.Black;
                CPU_Cnt = 0;
                CountCPU.Text = CPU_Cnt.ToString();
                PlusCPU.Enabled = false;
                MinusCPU.Enabled = false;
                CountCPU.Enabled = false;
            }
        }

        private void Get7800X3D_CheckedChanged(object sender, EventArgs e)//7800X3D담기 버튼
        {
            int tempPrice = 581560;
            if (Get7800X3D.BackColor == Color.Silver)
            {
                CPU_Cnt++;
                Get7800X3D.BackColor = Color.Black;
                Get7800X3D.ForeColor = Color.Silver;
                PlusCPU.Enabled = true;
                CountCPU.Enabled = true;
                MinusCPU.Enabled = true;
                CPUCartName.Text = "AMD 라이젠7-5세대 7800X3D";
                CountCPU.Text = (CPU_Cnt).ToString();
                PriceCPU = tempPrice;
                CPUCartPrice.Text = PriceCPU.ToString("#,##0원");
                TotalSum();



            }
            else
            {

                Get7800X3D.BackColor = Color.Silver;
                Get7800X3D.ForeColor = Color.Black;
                CPU_Cnt = 0;
                CountCPU.Text = CPU_Cnt.ToString();
                PlusCPU.Enabled = false;
                MinusCPU.Enabled = false;
                CountCPU.Enabled = false;
            }
        }
        //--------------------------------CPU상품을 카트에 담는 코드 끝------------------------------------------



        //-------------------------------상품의 개수를 조절하는 코드 시작-----------------------------------------
        private void PlusCPU_Click(object sender, EventArgs e)//CPU 개수 +
        {
            MinusCPU.Enabled = true;
            CPU_Cnt++;
            CountCPU.Text = CPU_Cnt.ToString();
            CPUCartPrice.Text = (PriceCPU * (int.Parse(CountCPU.Text))).ToString("#,##0원");
            TotalSum();

        }


        private void MinusCPU_Click(object sender, EventArgs e)//CPU 개수 -
        {
            if (CPU_Cnt > 0)
            {

                CPU_Cnt--;
                if (CPU_Cnt == 0)
                {
                    MinusCPU.Enabled = false;
                }
                CountCPU.Text = CPU_Cnt.ToString();
                CPUCartPrice.Text = (PriceCPU * (int.Parse(CountCPU.Text))).ToString("#,##0원");
                TotalSum();


            }
        }
        private void PlusCooler_Click(object sender, EventArgs e)//쿨러 개수+
        {
            MinusCooler.Enabled = true;
            Cooler_Cnt++;
            CountCooler.Text = Cooler_Cnt.ToString();
            CoolerCartPrice.Text = (PriceCooler * (int.Parse(CountCooler.Text))).ToString("#,##0원");
            TotalSum();

        }

        private void MinusCooler_Click(object sender, EventArgs e)//쿨러 개수-
        {
            if (Cooler_Cnt > 0)
            {

                Cooler_Cnt--;
                if (Cooler_Cnt == 0)
                {
                    MinusCooler.Enabled = false;
                }
                CountCooler.Text = Cooler_Cnt.ToString();
                CoolerCartPrice.Text = (PriceCooler * (int.Parse(CountCooler.Text))).ToString("#,##0원");
                TotalSum();


            }
        }

        private void PlusMainBoard_Click(object sender, EventArgs e)//메인보드 개수+
        {
            MinusMainBoard.Enabled = true;
            MainBoard_Cnt++;
            CountMainBoard.Text = MainBoard_Cnt.ToString();
            MainBoardCartPrice.Text = (PriceBoard * (int.Parse(CountMainBoard.Text))).ToString("#,##0원");
            TotalSum();

        }

        private void MinusMainBoard_Click(object sender, EventArgs e)//메인보드 개수-
        {
            if (MainBoard_Cnt > 0)
            {

                MainBoard_Cnt--;
                if (MainBoard_Cnt == 0)
                {
                    MinusMainBoard.Enabled = false;
                }
                CountMainBoard.Text = MainBoard_Cnt.ToString();
                MainBoardCartPrice.Text = (PriceBoard * (int.Parse(CountMainBoard.Text))).ToString("#,##0원");
                TotalSum();


            }
        }

        private void PlusMemory_Click(object sender, EventArgs e)//메모리 개수 +
        {
            MinusMemory.Enabled = true;
            Memory_Cnt++;
            CountMemory.Text = Memory_Cnt.ToString();
            MemoryCartPrice.Text = (PriceMemory * (int.Parse(CountMemory.Text))).ToString("#,##0원");
            TotalSum();

        }

        private void MinusMemory_Click(object sender, EventArgs e)//메모리 개수 -
        {
            if (Memory_Cnt > 0)
            {

                Memory_Cnt--;
                if (Memory_Cnt == 0)
                {
                    MinusMemory.Enabled = false;
                }
                CountMemory.Text = Memory_Cnt.ToString();
                MemoryCartPrice.Text = (PriceMemory * (int.Parse(CountMemory.Text))).ToString("#,##0원");
                TotalSum();


            }
        }

        private void PlusGPU_Click(object sender, EventArgs e)//그래픽카드 개수 +
        {
            MinusGPU.Enabled = true;
            GPU_Cnt++;
            CountGPU.Text = GPU_Cnt.ToString();
            GPUCartPrice.Text = (PriceGPU * (int.Parse(CountGPU.Text))).ToString("#,##0원");
            TotalSum();

        }

        private void MinusGPU_Click(object sender, EventArgs e)//그래픽카드 개수 -
        {
            if (GPU_Cnt > 0)
            {

                GPU_Cnt--;
                if (GPU_Cnt == 0)
                {
                    MinusGPU.Enabled = false;
                }
                CountGPU.Text = GPU_Cnt.ToString();
                GPUCartPrice.Text = (PriceGPU * (int.Parse(CountGPU.Text))).ToString("#,##0원");
                TotalSum();


            }
        }

        private void PlusSSD_Click(object sender, EventArgs e)//SSD 개수 +
        {
            MinusSSD.Enabled = true;
            SSD_Cnt++;
            CountSSD.Text = SSD_Cnt.ToString();
            SSDCartPrice.Text = (PriceSSD * (int.Parse(CountSSD.Text))).ToString("#,##0원");
            TotalSum();

        }

        private void MinusSSD_Click(object sender, EventArgs e)//SSD 개수 -
        {
            if (SSD_Cnt > 0)
            {

                SSD_Cnt--;
                if (SSD_Cnt == 0)
                {
                    MinusSSD.Enabled = false;
                }
                CountSSD.Text = SSD_Cnt.ToString();
                SSDCartPrice.Text = (PriceSSD * (int.Parse(CountSSD.Text))).ToString("#,##0원");
                TotalSum();


            }
        }

        private void PlusCase_Click(object sender, EventArgs e)//케이스 개수 +
        {
            MinusCase.Enabled = true;
            Case_Cnt++;
            CountCase.Text = Case_Cnt.ToString();
            CaseCartPrice.Text = (PriceCase * (int.Parse(CountCase.Text))).ToString("#,##0원");
            TotalSum();

        }

        private void MinusCase_Click(object sender, EventArgs e)//케이스 개수 -
        {
            if (Case_Cnt > 0)
            {

                Case_Cnt--;
                if (Case_Cnt == 0)
                {
                    MinusCase.Enabled = false;
                }
                CountCase.Text = Case_Cnt.ToString();
                CaseCartPrice.Text = (PriceCase * (int.Parse(CountCase.Text))).ToString("#,##0원");
                TotalSum();


            }
        }

        private void PlusPower_Click(object sender, EventArgs e)//파워 개수 +
        {
            MinusPower.Enabled = true;
            Power_Cnt++;
            CountPower.Text = Power_Cnt.ToString();
            PowerCartPrice.Text = (PricePower * (int.Parse(CountPower.Text))).ToString("#,##0원");
            TotalSum();

        }

        private void MinusPower_Click(object sender, EventArgs e)//파워 개수 -
        {
            if (Power_Cnt > 0)
            {

                Power_Cnt--;
                if (Power_Cnt == 0)
                {
                    MinusPower.Enabled = false;
                }
                CountPower.Text = Power_Cnt.ToString();
                PowerCartPrice.Text = (PricePower * (int.Parse(CountPower.Text))).ToString("#,##0원");
                TotalSum();


            }
        }

        //-------------------------------상품의 개수를 조절하는 코드 끝-----------------------------------------

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            //잘못생성된 이벤트
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            //잘못생성된 이벤트

        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            //잘못생성된 이벤트

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            //잘못생성된 이벤트

        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            //잘못생성된 이벤트

        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            //잘못생성된 이벤트

        }
        //-------------------------CPU 카트를 리셋하는 버튼 코드 시작------------------------------------
        private void CPUCartReset_Click(object sender, EventArgs e)
        {
            MinusCPU.Enabled = false;
            CountCPU.Enabled = false;
            PlusCPU.Enabled = false;
            Geti9_14900K.Checked = false;
            Geti7_14700K.Checked = false;
            Get7900X3D.Checked = false;
            Get7800X3D.Checked = false;
            CPU_Cnt = 0;
            PriceCPU = 0;
            CPUCartName.Text = "";
            CPUCartPrice.Text = "원";
            TotalSum();

        }
        //-------------------------CPU 카트를 리셋하는 버튼 코드 끝------------------------------------


        private void label9_Click(object sender, EventArgs e)
        {
            //잘못 생성된 이벤트
        }

        //---------------------------상품 정보를 툴팁으로 띄워주는 코드 시작------------------------------------
        private void ExplainAK400_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainAK400, "CPU 쿨러/싱글타워형/공랭/팬 쿨러/TDP:220W/A/S기간:3년/[호환/크기]/인텔 소켓:LGA1700,LGA1200,LGA115x/\nAMD 소켓:AM5,AM4/가로:127mm/세로:73mm/높이:155mm/무게:661g/[쿨링팬]/팬 크기:120mm/팬 개수:1개/25T/4핀/베어링:FDB(유체)/\n1850 RPM/최대 풍량:66.47 CFM/풍압(정압):2.04mmH₂O/최대 팬소음:29dBA/PWM 지원/non-LED");
        }

        private void ExplainAC6200_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainAC6200, "CPU 쿨러/듀얼타워형/공랭/팬 쿨러/TDP:250W/A/S기간:3년/[호환/크기]/인텔 소켓:LGA1700,LGA1200,LGA115x,\nLGA2066,LGA2011,LGA1366/AMD 소켓:AM5,AM4,FMx/AMx(AM1/4외)/가로:125mm/세로:135mm/높이:158mm/무게:1105g/[쿨링팬]/팬 크기:120mm/\n팬 개수:2개/25T/3-4핀/베어링:Hydraulic(유체)/1800 RPM/최대 풍량:75.8 CFM/풍압(정압):2.15mmH₂O/최대 팬소음:29.5dBA/\n[부가기능]/LED 라이트/PWM 지원/RGB/LED시스템:AURA SYNC,MYSTIC LIGHT,RGB FUSION,POLYCHROME");
        }

        private void ExplainM360_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainM360, "CPU 쿨러/수랭/팬 쿨러/A/S기간:5년/[호환/크기]/인텔 소켓:LGA1700,LGA1200,LGA2066,LGA2011-V3,LGA2011/\nAMD 소켓:AM5,AM4,TR4/[수랭]/라디에이터:3열/라디에이터 길이:397mm/라디에이터 두께:27mm/호스 길이:400mm/[쿨링팬]/팬 크기:120mm/\n팬 개수:3개/25T/4핀/베어링:2볼/2000 RPM/최대 풍량:78.73 CFM/풍압(정압):2.39mmH₂O/최대 팬소음:34.3dBA/[부가기능]/LED 라이트/\nPWM 지원/RGB/LED시스템:MYSTIC LIGHT");
        }

        private void ExplainMothra240_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainMothra240, "CPU 쿨러/수랭/팬 쿨러/TDP:200W/A/S기간:5년+누수보상/[호환/크기]/인텔 소켓:LGA1700,LGA1200,LGA115x,LGA2066,\nLGA2011,LGA1366/AMD 소켓:AM5,AM4,FMx/AMx(AM1/4외)/[수랭]/라디에이터:2열/라디에이터 길이:277mm/라디에이터 두께:27mm/\n호스 길이:390mm/[쿨링팬]/팬 크기:120mm/팬 개수:2개/25T/3-4핀/베어링:Hydraulic(유체)/1800 RPM/최대 풍량:63.34 CFM/\n풍압(정압):1.95mmH₂O/최대 팬소음:33.1dBA/[부가기능]/LED 라이트/PWM 지원/워터블록/로고 회전/RGB/LED시스템:AURA SYNC,\nMYSTIC LIGHT,RGB FUSION,POLYCHROME");
        }

        private void ExplainB760_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainB760, "인텔(소켓1700)/인텔 B760/M-ATX (24.4x24.4cm)/전원부:12+1+1페이즈/페이즈당60A/Vcore출력합계:720A/메모리/DDR5/\n7800MHz(PC5-62400)/4개/메모리 용량:최대 192GB/XMP/확장슬롯/VGA 연결:PCIe5.0 x16/PCIe버전:PCIe5.0,PCIe4.0/\nPCIex16:1개/PCIex16(at x4):1개/PCIex1:2개/저장장치/M.2:2개/SATA3:4개/M.2 연결:PCIe4.0,NVMe/후면단자/HDMI/DP/USB 3.2/\nUSB 3.1/USB 3.0/USB 2.0/RJ-45/오디오잭/BIOS 플래시백/랜/오디오/유선랜 칩셋:Intel/2.5기가비트/RJ-45:1개/무선랜(Wi-Fi)\n/블루투스/오디오 칩셋:SupremeFX S1220A/7.1채널(8ch)/내부I/O/I/O 헤더:USB4 헤더,USB 3.0 헤더,USB 2.0 헤더,USB3.1 \nType C 헤더,RGB 12V 4핀 헤더,ARGB 5V 3핀 헤더/시스템팬 4핀:2개/USB2.0 헤더:2개/USB3.0 헤더:1개/특징/전원부 방열판\n/M.2 히트싱크/LED 라이트/UEFI/23년 9월부로 최대 메모리 용량 변경");
        }

        private void ExplainB650_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainB650, "AMD(소켓AM5)/AMD B650/ATX (30.5x24.4cm)/전원부:12+2페이즈/페이즈당60A/Vcore출력합계:720A/메모리/DDR5/\n6400MHz (PC5-51200)/4개/메모리 용량:최대 128GB/EXPO/확장슬롯/VGA 연결:PCIe4.0 x16/PCIe버전:PCIe4.0,PCIe3.0/PCIex16:1개/\nPCIex16(at x4):1개/PCIex1:2개/저장장치/M.2:3개/SATA3:4개/M.2 연결:PCIe5.0,PCIe4.0,NVMe/후면단자/HDMI/DP/USB 3.2/\nUSB 3.1/USB 2.0/RJ-45/오디오잭/랜/오디오/유선랜 칩셋:Realtek/2.5기가비트/RJ-45:1개/오디오 칩셋:Realtek/7.1채널(8ch)/\n내부I/O/I/O 헤더:USB4 헤더,USB 3.0 헤더,USB 2.0 헤더,USB3.0 Type C 헤더,RGB 12V 4핀 헤더,ARGB 5V 3핀 헤더/시스템팬 \n4핀:4개/USB2.0 헤더:2개/USB3.0 헤더:1개/특징/전원부 방열판/DrMOS/M.2 히트싱크/UEFI");
        }

        private void ExplainX670E_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainX670E, "AMD(소켓AM5) / AMD X670E / ATX (30.5x24.4cm) / 전원부:16+2+2페이즈 / 페이즈당70A / Vcore출력합계:1120A / \n메모리 / DDR5 / 8000MHz (PC5-64000) / 4개 / 메모리 용량:최대 192GB / XMP / EXPO / 확장슬롯 / VGA 연결:PCIe5.0 x16 /\n PCIe버전:PCIe5.0;PCIe3.0 / PCIex16:1개 / PCIex16(at x4):1개 / PCIex16(at x2):1개 / 저장장치 / M.2:4개 / SATA3:4개 /\n M.2 연결:PCIe5.0;PCIe4.0 / 후면단자 / HDMI / USB 3.2 / USB 3.1 / USB 3.0 / USB 2.0 / RJ-45 / 오디오잭 / BIOS 플래시백 /\n 랜/오디오 / 유선랜 칩셋:Intel / 2.5기가비트 / RJ-45:1개 / Qualcomm QCNCM865 / 무선랜(Wi-Fi) / 블루투스 / \n오디오 칩셋:Realtek ALC897 / 7.1채널(8ch) / 내부I/O / I/O 헤더:썬더볼트4 헤더;USB 3.0 헤더;USB 2.0 헤더;USB3.2\nType C 헤더;TPM 헤더 / 시스템팬 4핀:4+2개 / USB2.0 헤더:2개 / USB3.0 헤더:2개 / 특징 / 전원부 방열판 / SPS(DrMOS) /\nM.2 히트싱크 / 일체형IO실드 / UEFI");
        }

        private void ExplainZ790_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainZ790, "인텔(소켓1700)/인텔 Z790/ATX (30.5x24.4cm)/전원부:16+1+1페이즈/페이즈당90A/Vcore출력합계:1440A/메모리/DDR5/7800MHz \n(PC5-62400)/4개/메모리 용량:최대 192GB/XMP3.0/확장슬롯/VGA 연결:PCIe5.0 x16/PCIe버전:PCIe5.0,PCIe4.0,PCIe3.0/\nPCIex16:1개/PCIex16(at x4):1개/PCIex1:1개/저장장치/M.2:4개/SATA3:8개/M.2 연결:PCIe5.0,PCIe4.0,NVMe,SATA,PCIe 레인공유,\nSATA 레인공유/후면단자/HDMI/DP/USB 3.2/USB 3.1/USB 3.0/RJ-45/S/PDIF/오디오잭/BIOS 플래시백/클리어CMOS/랜/오디오/\n유선랜 칩셋:Intel/2.5기가비트/RJ-45:1개/무선랜(Wi-Fi)/블루투스/오디오 칩셋:Realtek ALC4080/7.1채널(8ch)/내부I/O/I/O \n헤더:USB 3.0 헤더,USB 2.0 헤더,USB3.1 Type C 헤더,RGB 12V 4핀 헤더,ARGB 5V 3핀 헤더,TPM 헤더/시스템팬 4핀:6개/\nUSB2.0 헤더:2개/USB3.0 헤더:1개/특징/전원부 방열판/DrMOS/M.2 히트싱크/UEFI");
        }

        private void ExplainGskillD5_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainGskillD5, "데스크탑용/DDR5/5600MHz (PC5-44800)/램타이밍:CL36-36-36-89/1.20V/램개수:1개/XMP/EXPO/온다이ECC/히트싱크:미포함");
        }

        private void ExplainTeamGroupD5_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainTeamGroupD5, "데스크탑용/DDR5/5600MHz (PC5-44800)/램타이밍:CL46-46-46-90/1.10V/램개수:1개/온다이ECC/히트싱크:미포함");
        }

        private void ExplainMicronD4_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainMicronD4, "데스크탑용/DDR4/3200MHz (PC4-25600)/램타이밍:CL22/1.20V/램개수:1개/히트싱크:미포함/S832A: SR(단면), x8 based /\nS632A: SR(단면), x16 based 확인요");
        }

        private void ExplainSamsungD4_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainSamsungD4, "데스크탑용/DDR4/3200MHz (PC4-25600)/램개수:1개/히트싱크:미포함");
        }

        private void ExplainRx7600_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainRx7600, "RX 7600 / 베이스클럭:1770MHz / 부스트클럭:2695MHz / 스트림 프로세서:2048개 / PCIe4.0x16(at x8) / GDDR6(DDR6) / \n출력단자:HDMI2.1;DP1.4 / 부가기능:제로팬(0-dB기술);8K 지원;4K 지원;HDCP 지원 / 정격파워 550W 이상 / 전원 포트:8핀 x1 /\n 2개 팬 / 가로(길이):269.2mm / 두께:40.3mm / 백플레이트 / DrMOS / A/S 3년");
        }

        private void ExplainRx7900_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainRx7900, "RX 7900 XTX / 5nm / 스트림 프로세서:6144개 / PCIe4.0x16 / GDDR6(DDR6) / 출력단자:HDMI2.1;DP2.1 / 부가기능:제로팬\n(0-dB기술);8K 지원;4K 지원;HDR 지원;HDCP 2.3 / 정격파워 850W 이상 / 전원 포트:8핀 x3 / 3개 팬 / 가로(길이):352.9mm / \n두께:72.6mm / 백플레이트 / LED 라이트 / AURA SYNC");
        }

        private void ExplainRtx4090_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainRtx4090, "RTX 4090 / 4nm / 부스트클럭:2595MHz / OC클럭:2610MHz / 스트림 프로세서:16384개 / PCIe4.0x16 / GDDR6X(DDR6X) / \n출력단자:HDMI2.1;DP1.4 / 부가기능:제로팬(0-dB기술);8K 지원;4K 지원;HDR 지원;Dual BIOS;HDCP 지원 / 사용전력:최대 480W / \n정격파워 1000W 이상 / 전원 포트:16핀(12VHPWR) x1 / 3개 팬 / 가로(길이):336mm / 두께:78mm / 백플레이트 / DrMOS / \nLED 라이트 / MYSTIC LIGHT / 구성품:VGA지지대;4x8핀 to 16핀 커넥터");
        }

        private void ExplainRtx4070tiSuper_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainRtx4070tiSuper, "RTX 4070 Ti SUPER / 4nm / 베이스클럭:2340MHz / 부스트클럭:2670MHz / 스트림 프로세서:8448개 / PCIe4.0x16 /\n GDDR6X(DDR6X) / 출력단자:HDMI2.1;DP1.4 / 부가기능:제로팬(0-dB기술);8K 지원;4K 지원;HDR 지원;HDCP 2.3 / 사용전력:285W /\n 정격파워 750W 이상 / 전원 포트:16핀(12VHPWR) x1 / 3개 팬 / 가로(길이):328.9mm / 두께:63.4mm / 백플레이트 / \nDrMOS / LED 라이트 / ThunderMaster / 구성품:2x8핀 to 16핀 커넥터 / A/S 3년");
        }

        private void ExplainP41_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainP41, "내장형SSD/M.2 (2280)/PCIe4.0x4 (64GT/s)/NVMe 1.4/TLC(기타)/3D낸드/DRAM 탑재/DDR4 1GB/컨트롤러:SK하이닉스 Aries/\nPS5 호환/[성능]/순차읽기:7,000MB/s/순차쓰기:6,500MB/s/읽기IOPS:1,400K/쓰기IOPS:1,300K/[지원기능]/TRIM/GC/SLC캐싱/\nS.M.A.R.T/DEVSLP/AES 암호화/전용 S/W/[환경특성]/MTBF:150만시간/TBW:750TB/A/S기간:5년/방열판 미포함/두께:2.38mm/7g");
        }

        private void ExplainSn850x_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainSn850x, "내장형SSD/M.2 (2280)/PCIe4.0x4 (64GT/s)/NVMe 1.4/TLC(기타)/3D낸드/DRAM 탑재/PS5 호환/[성능]/순차읽기:7,300MB/s/\n순차쓰기:6,300MB/s/읽기IOPS:800K/쓰기IOPS:1,100K/[지원기능]/TRIM/S.M.A.R.T/전용 S/W/[환경특성]/TBW:600TB/\nA/S기간:5년,제한보증/방열판 미포함/두께:2.38mm/7.5g");
        }

        private void Explain970evo_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.Explain970evo, "내장형SSD / M.2 (2280) / PCIe3.0x4 (32GT/s) / NVMe 1.3 / TLC(토글) / 3D낸드 / DRAM 탑재 / DDR4 1GB / \n컨트롤러:삼성 Phoenix / [성능] / 순차읽기:3,500MB/s / 순차쓰기:3,300MB/s / 읽기IOPS:600K / 쓰기IOPS:550K / \n[지원기능] / TRIM / GC / S.M.A.R.T / DEVSLP / AES 암호화 / 전용 S/W / [환경특성] / MTBF:150만시간 / TBW:600TB / \nA/S기간:5년 / 방열판 미포함 / 두께:2.38mm / 최대 8g");
        }

        private void ExplainG2_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainG2, "내장형SSD/M.2 (2280)/PCIe3.0x4 (32GT/s)/NVMe 1.3/TLC(기타)/3D낸드/DRAM 탑재/컨트롤러:KIOXIA/[성능]/순차읽기:2,100MB/s/\n순차쓰기:1,700MB/s/읽기IOPS:360K/쓰기IOPS:400K/[지원기능]/TRIM/GC/S.M.A.R.T/ECC/전용 S/W/[환경특성]/MTBF:150만시간/\nTBW:800TB/A/S기간:5년,제한보증/방열판 미포함/두께:2.23mm/7.1g");
        }

        private void ExplainDlx21_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainDlx21, "PC케이스(ATX)/미들타워/파워미포함/Extended-ATX/표준-ATX/Micro-ATX/Mini-ITX/쿨링팬:총4개/LED팬:4개/측면 개폐 방식:스윙도어/\n측면:강화유리/후면:140mm LED x1/전면:140mm LED x3/너비(W):233mm/깊이(D):448mm/높이(H):493mm/파워 장착 길이:235mm/\n파워 위치:하단후면/VGA 장착 길이:400mm/CPU쿨러 장착높이:180mm/RGB 컨트롤/LED 색상:RGB");
        }

        private void ExplainD6_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainD6, "PC케이스(ATX)/미들타워/파워미포함/표준-ATX/Micro-ATX/Mini-ITX/쿨링팬:총6개/LED팬:4개/전면 패널 타입:메쉬/측면:강화유리/\n후면:120mm LED x1/전면:120mm LED x3/상단:120mm x2/너비(W):216mm/깊이(D):366mm/높이(H):463mm/파워 장착 길이:170~250mm/\n파워 위치:하단후면/VGA 장착 길이:330mm/CPU쿨러 장착높이:173mm/외부LED 컨트롤/LED 색상:RGB");
        }

        private void ExplainMl420_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainMl420, "PC케이스(ATX) / 빅타워 / 파워미포함 / 표준-ATX / Micro-ATX / 표준-ITX / ATX (BTF) / Micro-ATX (BTF) / 수직 PCI형태:\n슬롯변경형 / 쿨링팬:총4개 / LED팬:4개 / 전면 패널 타입:강화유리 / 측면:강화유리 / 후면:140mm LED x1 / 내부 측면:140mm LEDx3 /\n 너비(W):246mm / 깊이(D):525mm / 높이(H):522mm / 파워 장착 길이:280mm / 파워 위치:하단후면 / VGA 장착 길이:455mm / \nCPU쿨러 장착높이:180mm / RGB 컨트롤 / LED 색상:ARGB");
        }

        private void ExplainG30_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.ExplainG30, "PC케이스(ATX)/미들타워/파워미포함/표준-ATX/Micro-ATX/Mini-ITX/쿨링팬:총6개/LED팬:4개/전면 패널 타입:메쉬/측면:강화유리/\n후면:120mm LED x1/전면:120mm LED x3/상단:120mm x2/너비(W):225mm/깊이(D):385mm/높이(H):485mm/파워 장착 길이:345mm/\n파워 위치:하단후면/VGA 장착 길이:340mm/CPU쿨러 장착높이:175mm");
        }

        private void Explain850W_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.Explain850W, "ATX 파워 / 정격출력:850W / 80 PLUS 골드 / +12V 싱글레일 / +12V 가용률:99% / 액티브PFC / PF(역률):99% / 120mm 팬 / \n깊이:140mm / 무상 10년 / [커넥터] / 풀모듈러 / 메인전원:24핀(20+4) / 보조전원:8핀(4+4) 2개 / PCIe 8핀(6+2):3개 / \nSATA:8개 / IDE 4핀:4개 / FDD:1개 / [부가기능] / 팬리스모드 / 프리볼트 / 플랫케이블");

        }

        private void Explain600W_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.Explain600W, "ATX 파워 / 정격출력:600W / 80 PLUS 브론즈 / ETA인증:BRONZE / LAMBDA인증:STANDARD+ / +12V 싱글레일 / +12V 가용률:100% / \n액티브PFC / PF(역률):99% / 120mm 팬 / 깊이:140mm / 무상 7년 / [커넥터] / 케이블일체형 / 메인전원:24핀(20+4) / \n보조전원:8+4핀 1개 / PCIe 8핀(6+2):2개 / SATA:6개 / IDE 4핀:4개 / [부가기능] / 팬리스모드 / 자동 팬 조절 / 대기전력 1W 미만 / 플랫케이블");
        }

        private void Explain700W_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.Explain700W, "ATX 파워 / 정격출력:700W / 80 PLUS 브론즈 / ETA인증:BRONZE / LAMBDA인증:STANDARD / 전압변동:±0.3% / +12V 싱글레일 / \n+12V 가용률:100% / 액티브PFC / PF(역률):99% / 120mm 팬 / 깊이:140mm / 무상 7년 / [커넥터] / 케이블일체형 / \n메인전원:24핀(20+4) / 보조전원:8+4+4핀 1개 / PCIe 16핀(12+4):12VHPWR 1개 / PCIe 8핀(6+2):2개 / SATA:6개 / IDE 4핀:4개 /\n [부가기능] / 팬리스모드 / 자동 팬 조절 / 대기전력 1W 미만 / 플랫케이블");
        }

        private void Explain900W_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "상품 정보";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.Explain900W, "ATX 파워/정격출력:900W/ETA인증:SILVER/LAMBDA인증:STANDARD/+12V 싱글레일/+12V 가용률:100%/액티브PFC/PF(역률):99%/140mm 팬/\n깊이:150mm/무상 5년/[커넥터]/메인전원:24핀(20+4)/보조전원:8+4+4핀 1개/PCIe 16핀(12+4):12VHPWR 1개/PCIe 8핀(6+2):4개/\nSATA:6개/IDE 4핀:3개/[부가기능]/대기전력 1W 미만/플랫케이블");
        }
        //---------------------------상품 정보를 툴팁으로 띄워주는 코드 끝------------------------------------

        //--------------------------------상품을 카트에 담는 코드 시작------------------------------------------

        int Cooler_Cnt = 0;
        private void Get_AK400_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 29570;

            if (Get_AK400.BackColor == Color.Silver)
            {
                Cooler_Cnt++;
                Get_AK400.BackColor = Color.Black;
                Get_AK400.ForeColor = Color.Silver;
                PlusCooler.Enabled = true;
                CountCooler.Enabled = true;
                MinusCooler.Enabled = true;
                //카트에 담긴 CPU의 이름과 가격을 해당 CPU의 이름과 가격으로 변경
                CoolerCartName.Text = "DEEPCOOL AK400 (BLACK)";
                CountCooler.Text = (Cooler_Cnt).ToString();
                PriceCooler = tempPrice;
                CoolerCartPrice.Text = PriceCooler.ToString("#,##0원");
                TotalSum();


            }
            else
            {

                Get_AK400.BackColor = Color.Silver;
                Get_AK400.ForeColor = Color.Black;
                Cooler_Cnt = 0;
                CountCooler.Text = Cooler_Cnt.ToString();
                PlusCooler.Enabled = false;
                MinusCooler.Enabled = false;
                CountCooler.Enabled = false;
            }
        }

        private void Get_AC6200_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 59000;

            if (Get_AC6200.BackColor == Color.Silver)
            {
                Cooler_Cnt++;
                Get_AC6200.BackColor = Color.Black;
                Get_AC6200.ForeColor = Color.Silver;
                PlusCooler.Enabled = true;
                CountCooler.Enabled = true;
                MinusCooler.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                CoolerCartName.Text = "LEADCOOL POONG AC-6200 BOOSTER ARGB";
                CountCooler.Text = (Cooler_Cnt).ToString();
                PriceCooler = tempPrice;
                CoolerCartPrice.Text = PriceCooler.ToString("#,##0원");
                TotalSum();



            }
            else
            {

                Get_AC6200.BackColor = Color.Silver;
                Get_AC6200.ForeColor = Color.Black;
                Cooler_Cnt = 0;
                CountCooler.Text = Cooler_Cnt.ToString();
                PlusCooler.Enabled = false;
                MinusCooler.Enabled = false;
                CountCooler.Enabled = false;
            }
        }

        private void Get_M360_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 96120;

            if (Get_M360.BackColor == Color.Silver)
            {
                Cooler_Cnt++;
                Get_M360.BackColor = Color.Black;
                Get_M360.ForeColor = Color.Silver;
                PlusCooler.Enabled = true;
                CountCooler.Enabled = true;
                MinusCooler.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                CoolerCartName.Text = "MSI MAG 코어리퀴드 M360 박격포";
                CountCooler.Text = (Cooler_Cnt).ToString();
                PriceCooler = tempPrice;
                CoolerCartPrice.Text = PriceCooler.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_M360.BackColor = Color.Silver;
                Get_M360.ForeColor = Color.Black;
                Cooler_Cnt = 0;
                CountCooler.Text = Cooler_Cnt.ToString();
                PlusCooler.Enabled = false;
                MinusCooler.Enabled = false;
                CountCooler.Enabled = false;
            }
        }

        private void Get_MOTHRA240_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 95580;

            if (Get_MOTHRA240.BackColor == Color.Silver)
            {
                Cooler_Cnt++;
                Get_MOTHRA240.BackColor = Color.Black;
                Get_MOTHRA240.ForeColor = Color.Silver;
                PlusCooler.Enabled = true;
                CountCooler.Enabled = true;
                MinusCooler.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                CoolerCartName.Text = "맥스엘리트 MOTHRA 240 AIO ARGB V2 (BLACK)";
                CountCooler.Text = (Cooler_Cnt).ToString();
                PriceCooler = tempPrice;
                CoolerCartPrice.Text = PriceCooler.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_MOTHRA240.BackColor = Color.Silver;
                Get_MOTHRA240.ForeColor = Color.Black;
                Cooler_Cnt = 0;
                CountCooler.Text = Cooler_Cnt.ToString();
                PlusCooler.Enabled = false;
                MinusCooler.Enabled = false;
                CountCooler.Enabled = false;
            }
        }
        int MainBoard_Cnt = 0;
        private void Get_B760_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 258000;

            if (Get_B760.BackColor == Color.Silver)
            {
                MainBoard_Cnt++;
                Get_B760.BackColor = Color.Black;
                Get_B760.ForeColor = Color.Silver;
                PlusMainBoard.Enabled = true;
                CountMainBoard.Enabled = true;
                MinusMainBoard.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                MainBoardCartName.Text = "ASUS ROG STRIX B760-G GAMING WIFI 코잇";
                CountMainBoard.Text = (MainBoard_Cnt).ToString();
                PriceBoard = tempPrice;
                MainBoardCartPrice.Text = PriceBoard.ToString("#,##0원");
                TotalSum();


            }
            else
            {

                Get_B760.BackColor = Color.Silver;
                Get_B760.ForeColor = Color.Black;
                MainBoard_Cnt = 0;
                CountMainBoard.Text = MainBoard_Cnt.ToString();
                PlusMainBoard.Enabled = false;
                MinusMainBoard.Enabled = false;
                CountMainBoard.Enabled = false;
            }
        }

        private void Get_B650_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 309960;

            if (Get_B650.BackColor == Color.Silver)
            {
                MainBoard_Cnt++;
                Get_B650.BackColor = Color.Black;
                Get_B650.ForeColor = Color.Silver;
                PlusMainBoard.Enabled = true;
                CountMainBoard.Enabled = true;
                MinusMainBoard.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                MainBoardCartName.Text = "ASUS TUF Gaming B650-PLUS 대원씨티에스";
                CountMainBoard.Text = (MainBoard_Cnt).ToString();
                PriceBoard = tempPrice;
                MainBoardCartPrice.Text = PriceBoard.ToString("#,##0원A");
                TotalSum();

            }
            else
            {

                Get_B650.BackColor = Color.Silver;
                Get_B650.ForeColor = Color.Black;
                MainBoard_Cnt = 0;
                CountMainBoard.Text = MainBoard_Cnt.ToString();
                PlusMainBoard.Enabled = false;
                MinusMainBoard.Enabled = false;
                CountMainBoard.Enabled = false;
            }
        }

        private void Get_X670E_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 424630;

            if (Get_X670E.BackColor == Color.Silver)
            {
                MainBoard_Cnt++;
                Get_X670E.BackColor = Color.Black;
                Get_X670E.ForeColor = Color.Silver;
                PlusMainBoard.Enabled = true;
                CountMainBoard.Enabled = true;
                MinusMainBoard.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                MainBoardCartName.Text = "GIGABYTE X670E AORUS PRO X 피씨디렉트";
                CountMainBoard.Text = (MainBoard_Cnt).ToString();
                PriceBoard = tempPrice;
                MainBoardCartPrice.Text = PriceBoard.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_X670E.BackColor = Color.Silver;
                Get_X670E.ForeColor = Color.Black;
                MainBoard_Cnt = 0;
                CountMainBoard.Text = MainBoard_Cnt.ToString();
                PlusMainBoard.Enabled = false;
                MinusMainBoard.Enabled = false;
                CountMainBoard.Enabled = false;
            }
        }

        private void Get_Z790_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 450430;

            if (Get_Z790.BackColor == Color.Silver)
            {
                MainBoard_Cnt++;
                Get_Z790.BackColor = Color.Black;
                Get_Z790.ForeColor = Color.Silver;
                PlusMainBoard.Enabled = true;
                CountMainBoard.Enabled = true;
                MinusMainBoard.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                MainBoardCartName.Text = "MSI MAG Z790 토마호크 맥스 WIFI";
                CountMainBoard.Text = (MainBoard_Cnt).ToString();
                PriceBoard = tempPrice;
                MainBoardCartPrice.Text = PriceBoard.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_Z790.BackColor = Color.Silver;
                Get_Z790.ForeColor = Color.Black;
                MainBoard_Cnt = 0;
                CountMainBoard.Text = MainBoard_Cnt.ToString();
                PlusMainBoard.Enabled = false;
                MinusMainBoard.Enabled = false;
                CountMainBoard.Enabled = false;
            }
        }
        int Memory_Cnt = 0;
        private void Get_GSkillD5_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 68240;

            if (Get_GSkillD5.BackColor == Color.Silver)
            {
                Memory_Cnt++;
                Get_GSkillD5.BackColor = Color.Black;
                Get_GSkillD5.ForeColor = Color.Silver;
                PlusMemory.Enabled = true;
                CountMemory.Enabled = true;
                MinusMemory.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                MemoryCartName.Text = "G.SKILL DDR5-5600 CL36 AEGIS 5 (16GB)";
                CountMemory.Text = (Memory_Cnt).ToString();
                PriceMemory = tempPrice;
                MemoryCartPrice.Text = PriceMemory.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_GSkillD5.BackColor = Color.Silver;
                Get_GSkillD5.ForeColor = Color.Black;
                Memory_Cnt = 0;
                CountMemory.Text = Memory_Cnt.ToString();
                PlusMemory.Enabled = false;
                MinusMemory.Enabled = false;
                CountMemory.Enabled = false;
            }
        }

        private void Get_TeamGroupD5_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 61240;

            if (Get_TeamGroupD5.BackColor == Color.Silver)
            {
                Memory_Cnt++;
                Get_TeamGroupD5.BackColor = Color.Black;
                Get_TeamGroupD5.ForeColor = Color.Silver;
                PlusMemory.Enabled = true;
                CountMemory.Enabled = true;
                MinusMemory.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                MemoryCartName.Text = "TeamGroup DDR5-5600 CL46 Elite 서린 (16GB)";
                CountMemory.Text = (Memory_Cnt).ToString();
                PriceMemory = tempPrice;
                MemoryCartPrice.Text = PriceMemory.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_TeamGroupD5.BackColor = Color.Silver;
                Get_TeamGroupD5.ForeColor = Color.Black;
                Memory_Cnt = 0;
                CountMemory.Text = Memory_Cnt.ToString();
                PlusMemory.Enabled = false;
                MinusMemory.Enabled = false;
                CountMemory.Enabled = false;
            }
        }

        private void Get_MicronD4_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 22680;

            if (Get_MicronD4.BackColor == Color.Silver)
            {
                Memory_Cnt++;
                Get_MicronD4.BackColor = Color.Black;
                Get_MicronD4.ForeColor = Color.Silver;
                PlusMemory.Enabled = true;
                CountMemory.Enabled = true;
                MinusMemory.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                MemoryCartName.Text = "마이크론 Crucial DDR4-3200 CL22 대원씨티에스 (8GB)";
                CountMemory.Text = (Memory_Cnt).ToString();
                PriceMemory = tempPrice;
                MemoryCartPrice.Text = PriceMemory.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_MicronD4.BackColor = Color.Silver;
                Get_MicronD4.ForeColor = Color.Black;
                Memory_Cnt = 0;
                CountMemory.Text = Memory_Cnt.ToString();
                PlusMemory.Enabled = false;
                MinusMemory.Enabled = false;
                CountMemory.Enabled = false;
            }
        }

        private void Get_SamsungD4_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 29380;

            if (Get_SamsungD4.BackColor == Color.Silver)
            {
                Memory_Cnt++;
                Get_SamsungD4.BackColor = Color.Black;
                Get_SamsungD4.ForeColor = Color.Silver;
                PlusMemory.Enabled = true;
                CountMemory.Enabled = true;
                MinusMemory.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                MemoryCartName.Text = "삼성전자 DDR4-3200 (8GB)";
                CountMemory.Text = (Memory_Cnt).ToString();
                PriceMemory = tempPrice;
                MemoryCartPrice.Text = PriceMemory.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_SamsungD4.BackColor = Color.Silver;
                Get_SamsungD4.ForeColor = Color.Black;
                Memory_Cnt = 0;
                CountMemory.Text = Memory_Cnt.ToString();
                PlusMemory.Enabled = false;
                MinusMemory.Enabled = false;
                CountMemory.Enabled = false;
            }
        }

        int GPU_Cnt = 0;
        private void Get_RX7600_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 370340;

            if (Get_RX7600.BackColor == Color.Silver)
            {
                GPU_Cnt++;
                Get_RX7600.BackColor = Color.Black;
                Get_RX7600.ForeColor = Color.Silver;
                PlusGPU.Enabled = true;
                CountGPU.Enabled = true;
                MinusGPU.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                GPUCartName.Text = "ASRock 라데온 RX 7600 CHALLENGER OC D6 8GB 대원씨티에스";
                CountGPU.Text = (GPU_Cnt).ToString();
                PriceGPU = tempPrice;
                GPUCartPrice.Text = PriceGPU.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_RX7600.BackColor = Color.Silver;
                Get_RX7600.ForeColor = Color.Black;
                GPU_Cnt = 0;
                CountGPU.Text = GPU_Cnt.ToString();
                PlusGPU.Enabled = false;
                MinusGPU.Enabled = false;
                CountGPU.Enabled = false;
            }
        }

        private void Get_RX7900_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 1566000;

            if (Get_RX7900.BackColor == Color.Silver)
            {
                GPU_Cnt++;
                Get_RX7900.BackColor = Color.Black;
                Get_RX7900.ForeColor = Color.Silver;
                PlusGPU.Enabled = true;
                CountGPU.Enabled = true;
                MinusGPU.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                GPUCartName.Text = "ASUS TUF Gaming 라데온 RX 7900 XTX O24G OC D6 24GB 대원씨티에스";
                CountGPU.Text = (GPU_Cnt).ToString();
                PriceGPU = tempPrice;
                GPUCartPrice.Text = PriceGPU.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_RX7900.BackColor = Color.Silver;
                Get_RX7900.ForeColor = Color.Black;
                GPU_Cnt = 0;
                CountGPU.Text = GPU_Cnt.ToString();
                PlusGPU.Enabled = false;
                MinusGPU.Enabled = false;
                CountGPU.Enabled = false;
            }
        }

        private void Get_RTX4090_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 2988500;

            if (Get_RTX4090.BackColor == Color.Silver)
            {
                GPU_Cnt++;
                Get_RTX4090.BackColor = Color.Black;
                Get_RTX4090.ForeColor = Color.Silver;
                PlusGPU.Enabled = true;
                CountGPU.Enabled = true;
                MinusGPU.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                GPUCartName.Text = "MSI 지포스 RTX 4090 슈프림 X D6X 24GB 트라이프로져3S";
                CountGPU.Text = (GPU_Cnt).ToString();
                PriceGPU = tempPrice;
                GPUCartPrice.Text = PriceGPU.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_RTX4090.BackColor = Color.Silver;
                Get_RTX4090.ForeColor = Color.Black;
                GPU_Cnt = 0;
                CountGPU.Text = GPU_Cnt.ToString();
                PlusGPU.Enabled = false;
                MinusGPU.Enabled = false;
                CountGPU.Enabled = false;
            }
        }

        private void Get_RTX4070_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 1408110;

            if (Get_RTX4070.BackColor == Color.Silver)
            {
                GPU_Cnt++;
                Get_RTX4070.BackColor = Color.Black;
                Get_RTX4070.ForeColor = Color.Silver;
                PlusGPU.Enabled = true;
                CountGPU.Enabled = true;
                MinusGPU.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                GPUCartName.Text = "이엠텍 지포스 RTX 4070 Ti SUPER GAMINGPRO OC D6X 16GB";
                CountGPU.Text = (GPU_Cnt).ToString();
                PriceGPU = tempPrice;
                GPUCartPrice.Text = PriceGPU.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_RTX4070.BackColor = Color.Silver;
                Get_RTX4070.ForeColor = Color.Black;
                GPU_Cnt = 0;
                CountGPU.Text = GPU_Cnt.ToString();
                PlusGPU.Enabled = false;
                MinusGPU.Enabled = false;
                CountGPU.Enabled = false;
            }
        }

        int SSD_Cnt = 0;
        private void Get_P41_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 165240;

            if (Get_P41.BackColor == Color.Silver)
            {
                SSD_Cnt++;
                Get_P41.BackColor = Color.Black;
                Get_P41.ForeColor = Color.Silver;
                PlusSSD.Enabled = true;
                CountSSD.Enabled = true;
                MinusSSD.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                SSDCartName.Text = "SK하이닉스 Platinum P41 M.2 NVMe (1TB)";
                CountSSD.Text = (SSD_Cnt).ToString();
                PriceSSD = tempPrice;
                SSDCartPrice.Text = PriceSSD.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_P41.BackColor = Color.Silver;
                Get_P41.ForeColor = Color.Black;
                SSD_Cnt = 0;
                CountSSD.Text = SSD_Cnt.ToString();
                PlusSSD.Enabled = false;
                MinusSSD.Enabled = false;
                CountSSD.Enabled = false;
            }
        }

        private void Get_SN850X_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 128520;

            if (Get_SN850X.BackColor == Color.Silver)
            {
                SSD_Cnt++;
                Get_SN850X.BackColor = Color.Black;
                Get_SN850X.ForeColor = Color.Silver;
                PlusSSD.Enabled = true;
                CountSSD.Enabled = true;
                MinusSSD.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                SSDCartName.Text = "Western Digital WD BLACK SN850X M.2 NVMe (1TB)";
                CountSSD.Text = (SSD_Cnt).ToString();
                PriceSSD = tempPrice;
                SSDCartPrice.Text = PriceSSD.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_SN850X.BackColor = Color.Silver;
                Get_SN850X.ForeColor = Color.Black;
                SSD_Cnt = 0;
                CountSSD.Text = SSD_Cnt.ToString();
                PlusSSD.Enabled = false;
                MinusSSD.Enabled = false;
                CountSSD.Enabled = false;

            }
        }

        private void Get_970EVO_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 145800;

            if (Get_970EVO.BackColor == Color.Silver)
            {
                SSD_Cnt++;
                Get_970EVO.BackColor = Color.Black;
                Get_970EVO.ForeColor = Color.Silver;
                PlusSSD.Enabled = true;
                CountSSD.Enabled = true;
                MinusSSD.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                SSDCartName.Text = "삼성전자 970 EVO Plus M.2 NVMe (1TB)";
                CountSSD.Text = (SSD_Cnt).ToString();
                PriceSSD = tempPrice;
                SSDCartPrice.Text = PriceSSD.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_970EVO.BackColor = Color.Silver;
                Get_970EVO.ForeColor = Color.Black;
                SSD_Cnt = 0;
                CountSSD.Text = SSD_Cnt.ToString();
                PlusSSD.Enabled = false;
                MinusSSD.Enabled = false;
                CountSSD.Enabled = false;
            }
        }

        private void Get_G2_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 181440;

            if (Get_G2.BackColor == Color.Silver)
            {
                SSD_Cnt++;
                Get_G2.BackColor = Color.Black;
                Get_G2.ForeColor = Color.Silver;
                PlusSSD.Enabled = true;
                CountSSD.Enabled = true;
                MinusSSD.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                SSDCartName.Text = "키오시아 EXCERIA G2 M.2 NVMe (2TB)";
                CountSSD.Text = (SSD_Cnt).ToString();
                PriceSSD = tempPrice;
                SSDCartPrice.Text = PriceSSD.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_G2.BackColor = Color.Silver;
                Get_G2.ForeColor = Color.Black;
                SSD_Cnt = 0;
                CountSSD.Text = SSD_Cnt.ToString();
                PlusSSD.Enabled = false;
                MinusSSD.Enabled = false;
                CountSSD.Enabled = false;
            }
        }

        int Case_Cnt = 0;
        private void Get_DLX21_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 94940;

            if (Get_DLX21.BackColor == Color.Silver)
            {
                Case_Cnt++;
                Get_DLX21.BackColor = Color.Black;
                Get_DLX21.ForeColor = Color.Silver;
                PlusCase.Enabled = true;
                CountCase.Enabled = true;
                MinusCase.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                CaseCartName.Text = "darkFlash DLX21 RGB MESH 강화유리 (화이트)";
                CountCase.Text = (Case_Cnt).ToString();
                PriceCase = tempPrice;
                CaseCartPrice.Text = PriceCase.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_DLX21.BackColor = Color.Silver;
                Get_DLX21.ForeColor = Color.Black;
                Case_Cnt = 0;
                CountCase.Text = Case_Cnt.ToString();
                PlusCase.Enabled = false;
                MinusCase.Enabled = false;
                CountCase.Enabled = false;
            }
        }

        private void Get_D6_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 39670;

            if (Get_D6.BackColor == Color.Silver)
            {
                Case_Cnt++;
                Get_D6.BackColor = Color.Black;
                Get_D6.ForeColor = Color.Silver;
                PlusCase.Enabled = true;
                CountCase.Enabled = true;
                MinusCase.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                CaseCartName.Text = "DAVEN D6 MESH 강화유리 (블랙)";
                CountCase.Text = (Case_Cnt).ToString();
                PriceCase = tempPrice;
                CaseCartPrice.Text = PriceCase.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_D6.BackColor = Color.Silver;
                Get_D6.ForeColor = Color.Black;
                Case_Cnt = 0;
                CountCase.Text = Case_Cnt.ToString();
                PlusCase.Enabled = false;
                MinusCase.Enabled = false;
                CountCase.Enabled = false;
            }
        }

        private void Get_ML420_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 139750;

            if (Get_ML420.BackColor == Color.Silver)
            {
                Case_Cnt++;
                Get_ML420.BackColor = Color.Black;
                Get_ML420.ForeColor = Color.Silver;
                PlusCase.Enabled = true;
                CountCase.Enabled = true;
                MinusCase.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                CaseCartName.Text = "마이크로닉스 ML-420 View BTF (화이트)";
                CountCase.Text = (Case_Cnt).ToString();
                PriceCase = tempPrice;
                CaseCartPrice.Text = PriceCase.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_ML420.BackColor = Color.Silver;
                Get_ML420.ForeColor = Color.Black;
                Case_Cnt = 0;
                CountCase.Text = Case_Cnt.ToString();
                PlusCase.Enabled = false;
                MinusCase.Enabled = false;
                CountCase.Enabled = false;
            }
        }

        private void Get_G30_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 47300;

            if (Get_G30.BackColor == Color.Silver)
            {
                Case_Cnt++;
                Get_G30.BackColor = Color.Black;
                Get_G30.ForeColor = Color.Silver;
                PlusCase.Enabled = true;
                CountCase.Enabled = true;
                MinusCase.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                CaseCartName.Text = "앱코 NCORE G30 트루포스 (블랙)";
                CountCase.Text = (Case_Cnt).ToString();
                PriceCase = tempPrice;
                CaseCartPrice.Text = PriceCase.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_G30.BackColor = Color.Silver;
                Get_G30.ForeColor = Color.Black;
                Case_Cnt = 0;
                CountCase.Text = Case_Cnt.ToString();
                PlusCase.Enabled = false;
                MinusCase.Enabled = false;
                CountCase.Enabled = false;
            }
        }
        int Power_Cnt = 0;
        private void Get_850W_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 145800;

            if (Get_850W.BackColor == Color.Silver)
            {
                Power_Cnt++;
                Get_850W.BackColor = Color.Black;
                Get_850W.ForeColor = Color.Silver;
                PlusPower.Enabled = true;
                CountPower.Enabled = true;
                MinusPower.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                PowerCartName.Text = "darkFlash UPMOST 850W 80PLUS GOLD FULL MODULAR 화이트";
                CountPower.Text = (Power_Cnt).ToString();
                PricePower = tempPrice;
                PowerCartPrice.Text = PricePower.ToString("#,##0원");
                TotalSum();


            }
            else
            {

                Get_850W.BackColor = Color.Silver;
                Get_850W.ForeColor = Color.Black;
                Power_Cnt = 0;
                CountPower.Text = Power_Cnt.ToString();
                PlusPower.Enabled = false;
                MinusPower.Enabled = false;
                CountPower.Enabled = false;
            }
        }

        private void Get_600W_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 59940;

            if (Get_600W.BackColor == Color.Silver)
            {
                Power_Cnt++;
                Get_600W.BackColor = Color.Black;
                Get_600W.ForeColor = Color.Silver;
                PlusPower.Enabled = true;
                CountPower.Enabled = true;
                MinusPower.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                PowerCartName.Text = "마이크로닉스 Classic II 풀체인지 600W 80PLUS BRONZE 230V EU";
                CountPower.Text = (Power_Cnt).ToString();
                PricePower = tempPrice;
                PowerCartPrice.Text = PricePower.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_600W.BackColor = Color.Silver;
                Get_600W.ForeColor = Color.Black;
                Power_Cnt = 0;
                CountPower.Text = Power_Cnt.ToString();
                PlusPower.Enabled = false;
                MinusPower.Enabled = false;
                CountPower.Enabled = false;
            }
        }

        private void Get_700W_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 80660;

            if (Get_700W.BackColor == Color.Silver)
            {
                Power_Cnt++;
                Get_700W.BackColor = Color.Black;
                Get_700W.ForeColor = Color.Silver;
                PlusPower.Enabled = true;
                CountPower.Enabled = true;
                MinusPower.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                PowerCartName.Text = "마이크로닉스 Classic II 풀체인지 700W 80PLUS BRONZE 230V EU";
                CountPower.Text = (Power_Cnt).ToString();
                PricePower = tempPrice;
                PowerCartPrice.Text = PricePower.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_700W.BackColor = Color.Silver;
                Get_700W.ForeColor = Color.Black;
                Power_Cnt = 0;
                CountPower.Text = Power_Cnt.ToString();
                PlusPower.Enabled = false;
                MinusPower.Enabled = false;
                CountPower.Enabled = false;
            }
        }

        private void Get_900W_CheckedChanged(object sender, EventArgs e)
        {
            int tempPrice = 91260;

            if (Get_900W.BackColor == Color.Silver)
            {
                Power_Cnt++;
                Get_900W.BackColor = Color.Black;
                Get_900W.ForeColor = Color.Silver;
                PlusPower.Enabled = true;
                CountPower.Enabled = true;
                MinusPower.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                PowerCartName.Text = "마이크로닉스 COOLMAX FOCUS II 900W ETA SILVER PCIE5";
                CountPower.Text = (Power_Cnt).ToString();
                PricePower = tempPrice;
                PowerCartPrice.Text = PricePower.ToString("#,##0원");
                TotalSum();

            }
            else
            {

                Get_900W.BackColor = Color.Silver;
                Get_900W.ForeColor = Color.Black;
                Power_Cnt = 0;
                CountPower.Text = Power_Cnt.ToString();
                PlusPower.Enabled = false;
                MinusPower.Enabled = false;
                CountPower.Enabled = false;
            }
        }
        //--------------------------------상품을 카트에 담는 코드 끝------------------------------------------


        //--------------------------------카트를 리셋하는 코드 시작-------------------------------------------
        private void CoolerCartReset_Click(object sender, EventArgs e)
        {
            MinusCooler.Enabled = false;
            CountCooler.Enabled = false;
            PlusCooler.Enabled = false;
            Get_AK400.Checked = false;
            Get_AC6200.Checked = false;
            Get_M360.Checked = false;
            Get_MOTHRA240.Checked = false;
            Cooler_Cnt = 0;
            PriceCooler = 0;
            CoolerCartName.Text = "";
            CoolerCartPrice.Text = "원";
            TotalSum();

        }

        private void MainBoardCartReset_Click(object sender, EventArgs e)
        {
            MinusMainBoard.Enabled = false;
            CountMainBoard.Enabled = false;
            PlusMainBoard.Enabled = false;
            Get_B760.Checked = false;
            Get_B650.Checked = false;
            Get_X670E.Checked = false;
            Get_Z790.Checked = false;
            MainBoard_Cnt = 0;
            PriceBoard = 0;
            MainBoardCartName.Text = "";
            MainBoardCartPrice.Text = "원";
            TotalSum();

        }

        private void MemoryCartReset_Click(object sender, EventArgs e)
        {
            MinusMemory.Enabled = false;
            CountMemory.Enabled = false;
            PlusMemory.Enabled = false;
            Get_GSkillD5.Checked = false;
            Get_TeamGroupD5.Checked = false;
            Get_MicronD4.Checked = false;
            Get_SamsungD4.Checked = false;
            Memory_Cnt = 0;
            PriceMemory = 0;
            MemoryCartName.Text = "";
            MemoryCartPrice.Text = "원";
            TotalSum();

        }

        private void GPUCartReset_Click(object sender, EventArgs e)
        {
            MinusGPU.Enabled = false;
            CountGPU.Enabled = false;
            PlusGPU.Enabled = false;
            Get_RX7600.Checked = false;
            Get_RX7900.Checked = false;
            Get_RTX4090.Checked = false;
            Get_RTX4070.Checked = false;
            GPU_Cnt = 0;
            PriceGPU = 0;
            GPUCartName.Text = "";
            GPUCartPrice.Text = "원";
            TotalSum();

        }

        private void SSDCartReset_Click(object sender, EventArgs e)
        {
            MinusSSD.Enabled = false;
            CountSSD.Enabled = false;
            PlusSSD.Enabled = false;
            Get_P41.Checked = false;
            Get_SN850X.Checked = false;
            Get_970EVO.Checked = false;
            Get_G2.Checked = false;
            SSD_Cnt = 0;
            PriceSSD = 0;
            SSDCartName.Text = "";
            SSDCartPrice.Text = "원";
            TotalSum();

        }

        private void CaseCartReset_Click(object sender, EventArgs e)
        {
            MinusCase.Enabled = false;
            CountCase.Enabled = false;
            PlusCase.Enabled = false;
            Get_DLX21.Checked = false;
            Get_D6.Checked = false;
            Get_ML420.Checked = false;
            Get_G30.Checked = false;
            Case_Cnt = 0;
            PriceCase = 0;
            CaseCartName.Text = "";
            CaseCartPrice.Text = "원";
            TotalSum();

        }

        private void PowerCartReset_Click(object sender, EventArgs e)
        {
            MinusPower.Enabled = false;
            CountPower.Enabled = false;
            PlusPower.Enabled = false;
            Get_850W.Checked = false;
            Get_600W.Checked = false;
            Get_700W.Checked = false;
            Get_900W.Checked = false;
            Power_Cnt = 0;
            PricePower = 0;
            PowerCartName.Text = "";
            PowerCartPrice.Text = "원";
            TotalSum();

        }

        private void ConfirmBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ConfirmBtn.BackColor = Color.Gray;
        }

        private void ConfirmBtn_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void BuyBtn_MouseDown(object sender, MouseEventArgs e)
        {
            BuyBtn.BackColor = Color.OrangeRed;
            TransPrice = ResultPrice.Text;

        }

        private void BuyBtn_MouseUp(object sender, MouseEventArgs e)
        {
            BuyBtn.BackColor = Color.Coral;
            ConfirmBtn.BackColor = Color.Gainsboro;
            DialogResult result = MessageBox.Show("구매하시겠습니까?", "구매", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Buy buy = new Buy();
                buy.ShowDialog();
            }

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("아직 못만들었어요 ^^");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MinusCPU.Enabled = false;
            CountCPU.Enabled = false;
            PlusCPU.Enabled = false;
            Geti9_14900K.Checked = false;
            Geti7_14700K.Checked = false;
            Get7900X3D.Checked = false;
            Get7800X3D.Checked = false;
            CPU_Cnt = 0;
            PriceCPU = 0;
            CPUCartName.Text = "";
            CPUCartPrice.Text = "원";
            TotalSum();

            MinusCooler.Enabled = false;
            CountCooler.Enabled = false;
            PlusCooler.Enabled = false;
            Get_AK400.Checked = false;
            Get_AC6200.Checked = false;
            Get_M360.Checked = false;
            Get_MOTHRA240.Checked = false;
            Cooler_Cnt = 0;
            PriceCooler = 0;
            CoolerCartName.Text = "";
            CoolerCartPrice.Text = "원";
            TotalSum();

            MinusMainBoard.Enabled = false;
            CountMainBoard.Enabled = false;
            PlusMainBoard.Enabled = false;
            Get_B760.Checked = false;
            Get_B650.Checked = false;
            Get_X670E.Checked = false;
            Get_Z790.Checked = false;
            MainBoard_Cnt = 0;
            PriceBoard = 0;
            MainBoardCartName.Text = "";
            MainBoardCartPrice.Text = "원";
            TotalSum();

            MinusMemory.Enabled = false;
            CountMemory.Enabled = false;
            PlusMemory.Enabled = false;
            Get_GSkillD5.Checked = false;
            Get_TeamGroupD5.Checked = false;
            Get_MicronD4.Checked = false;
            Get_SamsungD4.Checked = false;
            Memory_Cnt = 0;
            PriceMemory = 0;
            MemoryCartName.Text = "";
            MemoryCartPrice.Text = "원";
            TotalSum();

            MinusGPU.Enabled = false;
            CountGPU.Enabled = false;
            PlusGPU.Enabled = false;
            Get_RX7600.Checked = false;
            Get_RX7900.Checked = false;
            Get_RTX4090.Checked = false;
            Get_RTX4070.Checked = false;
            GPU_Cnt = 0;
            PriceGPU = 0;
            GPUCartName.Text = "";
            GPUCartPrice.Text = "원";
            TotalSum();

            MinusSSD.Enabled = false;
            CountSSD.Enabled = false;
            PlusSSD.Enabled = false;
            Get_P41.Checked = false;
            Get_SN850X.Checked = false;
            Get_970EVO.Checked = false;
            Get_G2.Checked = false;
            SSD_Cnt = 0;
            PriceSSD = 0;
            SSDCartName.Text = "";
            SSDCartPrice.Text = "원";
            TotalSum();

            MinusCase.Enabled = false;
            CountCase.Enabled = false;
            PlusCase.Enabled = false;
            Get_DLX21.Checked = false;
            Get_D6.Checked = false;
            Get_ML420.Checked = false;
            Get_G30.Checked = false;
            Case_Cnt = 0;
            PriceCase = 0;
            CaseCartName.Text = "";
            CaseCartPrice.Text = "원";
            TotalSum();

            MinusPower.Enabled = false;
            CountPower.Enabled = false;
            PlusPower.Enabled = false;
            Get_850W.Checked = false;
            Get_600W.Checked = false;
            Get_700W.Checked = false;
            Get_900W.Checked = false;
            Power_Cnt = 0;
            PricePower = 0;
            PowerCartName.Text = "";
            PowerCartPrice.Text = "원";
            TotalSum();
        }

        //--------------------------------카트를 리셋하는 코드 끝-------------------------------------------

    }
}
/*
 *          int tempPrice = 상품의가격쓰기;

            if (겟이름쓰기.BackColor == Color.Silver)
            {
                부품카운트++;
                겟이름쓰기.BackColor = Color.Black;
                겟이름쓰기.ForeColor = Color.Silver;
                플러스부품.Enabled = true;
                카운트부품.Enabled = true;
                마이너스부품.Enabled = true;
                //카트에 담긴 부품의 이름과 가격을 해당 부품의 이름과 가격으로 변경
                부품카트이름.Text = "상품의이름을적기";
                카운트부품.Text = (부품카운트).ToString();
                부품카트가격.Text = (tempPrice * int.Parse(카운트부품.Text)).ToString("#,##0원");
            }
            else
            {

                겟이름쓰기.BackColor = Color.Silver;
                겟이름쓰기.ForeColor = Color.Black;
                부품카운트 = 0;
                카운트부품.Text = 부품카운트.ToString();
                플러스부품.Enabled = false;
                마이너스부품.Enabled = false;
                카운트부품.Enabled = false;
            }
 */