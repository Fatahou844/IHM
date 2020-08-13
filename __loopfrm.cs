using System;

using System.Drawing;

using System.Windows.Forms;

namespace Interface_RADAR
{

    public partial class __loopfrm : Form
    {
        Radar _radar;
        Timer t = new Timer();
        Random rnd = new Random();
        
       
        
        public __loopfrm()
        {
            InitializeComponent();
            // internal item update timer
            pictureBox1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel3.BackColor = Color.Transparent;
            flowLayoutPanel4.BackColor = Color.Transparent;
            flowLayoutPanel5.BackColor = Color.Transparent;
            flowLayoutPanel6.BackColor = Color.Transparent;
            flowLayoutPanel7.BackColor = Color.Transparent;
            flowLayoutPanel8.BackColor = Color.Transparent;
            flowLayoutPanel9.BackColor = Color.Transparent;
            
            //    this.Size = new Size(1600,900);
            iconDimin.Visible = true;
            iconMaxim.Visible = false;

            //pictureBox5.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            t.Interval = 60;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
            init();
        }
        /* RadarItem item1 = new SquareRadarItem(1, 8, 45, 7);
         RadarItem item2 = new CircleRadarItem(2, 8, -45, 15);
         RadarItem item3 = new TriangleRadarItem(3, 8, 30, 19); */
        // Valeurs ajustables en fonction de la trame 
         
         static int Target_Human = 4 ;
         static int Target_Vehicle = 3;
         static int Target_Notid = 2; 
         static int nombre = 6;
        
         static float[] vitesses = new float[nombre];
         static float[] portees = new float[nombre];
         static float[] angles = new float[nombre];
         static int[] classes = new int[nombre];

        

         RadarItem[] human = new TriangleRadarItem[Target_Human];
         RadarItem[] vehicle = new SquareRadarItem[Target_Vehicle];
         RadarItem[] notid = new CircleRadarItem[Target_Notid]; 
         

         /* Fonction de récuperation des données 
          * Reprogrammation de la fonction getDelta pour mettre a jour les données des cibles radars
          * 
          * 
             */
       
        public object pictureBox5 { get; }

        // Fonction d'initialisation des cibles 
        void init() // Initialisation des premiers valeurs
        {
            for (int j = 0; j < Target_Human; j++)
            {
                human[j] = new TriangleRadarItem(j, 8, 45, 12);
            }

            for (int j = 0; j < Target_Vehicle; j++)
            {
                vehicle[j] = new SquareRadarItem(j + Target_Human, 8, -15, 11);
            }

            for (int j = 0; j < Target_Notid; j++)
            {
                notid[j] = new CircleRadarItem(j + Target_Human + Target_Vehicle, 8, -70, 15);
            }
        } 

        int GetDelta() // Mise à jour des données, vitesse, azimuth, portée 
        {
            int i = rnd.Next(0, 2);
            if (i == 0)
                i--;
            return i;
        }
       
        void t_Tick(object sender, EventArgs e)
        {
            // select which of the three items to update


            int i = rnd.Next(0, Target_Human + Target_Vehicle + Target_Notid);

            /*  switch (i)
              {
                  case 1:

                      item1.Azimuth += GetDelta();
                      item1.Range += GetDelta();
                      _radar.AddItem(item1);
                      break;
                  case 2:
                      item2.Azimuth += GetDelta();
                      item2.Range += GetDelta();
                      _radar.AddItem(item2);
                      break;
                  case 3:
                      item3.Azimuth += GetDelta();
                      item3.Range += GetDelta();
                      _radar.AddItem(item3);
                      break;


              } */
            // _radar.AddItem(new CircleRadarItem(classes[0], 8, -42, 4));
            // _radar.AddItem(new SquareRadarItem(classes[0], 8, 5, 16));
            //_radar.AddItem(new SquareRadarItem(classes[1], 8, 5, 16));
           /* data_received();
            for (int j = 0; j < nombre; j++)
          
            
                {
                if (classes[j] == 1)
                {
                    _radar.AddItem(new TriangleRadarItem(j, 8, (int)(angles[j]), (int)(portees[j])));
                   // _radar.AddItem(new TriangleRadarItem(j, 8, -50, 6));
                  
                   
                    // Console.WriteLine("Human");

                }

                if (classes[j] == 2)
                {
                    _radar.AddItem(new SquareRadarItem(j, 8, (int)(angles[j]), (int)(portees[j])));
                   // _radar.AddItem(new SquareRadarItem(j, 8, 5, 16));
                    

                }

                if (classes[j] == 3)
                {
                    _radar.AddItem(new CircleRadarItem(j, 8, (int)(angles[j]), (int)(portees[j])));
                  //  _radar.AddItem(new CircleRadarItem(j, 8, 60, 16));
                    

                }
               // _radar.AddItem(new SquareRadarItem(nombre, 8, 5, 16));


            }
            */
           
            if (i >= 1 & i < Target_Human)
            {
                human[i].Azimuth += GetDelta();
                human[i].Range += GetDelta();
                _radar.AddItem(human[i]);
            }

            if (i >= Target_Human + 1 & i < Target_Human + Target_Vehicle)
            {
                vehicle[i - Target_Human].Azimuth += GetDelta();
                vehicle[i - Target_Human].Range += GetDelta();
                _radar.AddItem(vehicle[i - Target_Human]);

            }

            if (i >= Target_Human + Target_Vehicle + 1 & i < Target_Human + Target_Vehicle + Target_Notid)
            {
                notid[i - Target_Human - Target_Vehicle].Azimuth += GetDelta();
                notid[i - Target_Human - Target_Vehicle].Range += GetDelta();
                _radar.AddItem(notid[i - Target_Human - Target_Vehicle]);

            }

            

        }

        private void __loopfrm_Load(object sender, EventArgs e)
        {
            _radar = new Radar(pictureBox1.Width);
            pictureBox1.Image = _radar.Image;
            _radar.ImageUpdate += new ImageUpdateHandler(_radar_ImageUpdate);
            _radar.DrawScanInterval = 60;
            _radar.DrawScanLine = true;
        }

        void _radar_ImageUpdate(object sender, ImageUpdateEventArgs e)
        {
            // this event is important to catch!
            pictureBox1.Image = e.Image;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconDimin.Visible = false;
            iconMaxim.Visible = true;

      

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void iconMaxim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconDimin.Visible = true;
            iconMaxim.Visible = false;
    

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_3(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
