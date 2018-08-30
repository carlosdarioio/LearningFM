using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLFingerPrintPro
{
    public partial class FingerPrintSinc : Form
    {
        xService.xRRHHEmployee xFindEmployee;
        List<xService.xRRHHFingerPrint> xListAllRegisteredSign = new List<xService.xRRHHFingerPrint>();
        xService.Service1Client xServiceClient;
        Timer tm = new Timer();
        public FingerPrintSinc()
        {
            InitializeComponent();
        }

        public void MC(/*MemoryStream FotoGuardada*/)
        {           

            tm.Stop();   //  1800000;   
            //120000 = 2 minutos  
            tm.Interval = 360000;//tenia 3840000 //pa prueba 120000
            tm.Tick += timerTick;
            //pbHuella.Visible = true;
            tm.Enabled = true;
            tm.Start();

        }

        private void timerTick(object sender, EventArgs e)
        {
            // pbHuella.Visible = false;
            
            ((Timer)sender).Stop();
            btnsinc.PerformClick();
            //this.Close();
            // label1.Text = "Esperando Huella";
        }

        private void FingerPrintSinc_Load(object sender, EventArgs e)
        {
            

            string fecha = "Pendientes ";
            try
            {
                xServiceClient = new xService.Service1Client();
                fecha += xServiceClient.xGetHorasPend(xServiceClient.xGetServerTime().ToString("yyyyMMdd"));
                label1.Text = fecha;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
                label1.Text = ex.ToString();
            }
            finally
            {
                xServiceClient.Close();
                xServiceClient.Abort();
            }
            
            MC();
        }
        //por aqui vas tratando de sincornizar marcaje a as400               
        //idea   --primero select  al servidor el server aacomoda los valores pa ingresar al as400, ingresa y cambia estado en local
        private void btnsinc_Click(object sender, EventArgs e)
        {
            string fecha = "Pendientes ";
            try
            {
                xServiceClient = new xService.Service1Client();
                fecha += xServiceClient.xSincHoras(xServiceClient.xGetServerTime().ToString("yyyyMMdd"));//
                /*crear la opcion de sincronizar y al terminar mostrar msj*/
                label1.Text = fecha + " Sincronizacion terminada.";
                this.Close();
                
                //MessageBox.Show("Sincronizacion terminada");
            }
            catch (Exception ex)
            {
               //MessageBox.Show(ex.ToString());
                label1.Text = ex.ToString();
            }
            finally
            {
                xServiceClient.Close();
                xServiceClient.Abort();
            }

            MC();
             
        }
    }
}
