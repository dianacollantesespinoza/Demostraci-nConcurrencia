using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class frmpedido : Form
    {
        private int Contadorpedido = 0;
        private object pedido = new();
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);
        public frmpedido()
        {
            InitializeComponent();
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                semaforo.Wait();

                lock (pedido)
                {

                    Contadorpedido++;
                    Thread.Sleep(5000);

                    this.Invoke((MethodInvoker)delegate
                    {
                        lblContadorpedido.Text = Contadorpedido.ToString();
                    });
                    Monitor.Pulse(pedido);
                }

                semaforo.Release();
            });
        }

        private void btnDisminuirpedido_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                lock (pedido)
                {
                    while (Contadorpedido <= 0)
                    {
                        ActualizarResultado("Esperando el pedido...");
                        Monitor.Wait(Contadorpedido);
                    }

                    if (Contadorpedido > 0)
                    {
                        Contadorpedido--;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {
                            lblContadorpedido.Text = Contadorpedido.ToString();
                        });

                    }
                    ActualizarResultado("Procesando el pedido...");


                }

            });
        }
        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            txtResultado.AppendText($" {DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }
    }
}
