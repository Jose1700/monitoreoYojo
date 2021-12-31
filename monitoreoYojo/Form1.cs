using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitoreoYojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaracion de variables
        //Declarar una variable de transmisión cuyo almacenamiento de respaldo sea la memoria
        MemoryStream ms;
        //Declaramos una variable para crear una conexion de cliente por TCP
        TcpClient tcpClient = null;
        //Declarar una variable de tipo imagen
        Bitmap imagenEscritorio;
        //Declaramos una variable
        Boolean valor = true;
        //Declaramos una variable tipo byte
        byte[] datosImagen;
        //Declaramos una variable de tipo network stream = proporciona el flujo de datos subyacente para el acceso a la red
        NetworkStream stream;
        //Declaramos una variable tipo entero para utilizarlo como un contador
        int contador = 0;
        //declaramos 2 variables tipo boolean para utilizarlas para iniciar el proceso de transmision de pantalla
        bool inicioCompartir = false;
        bool inicioVisualizar = false;
        //Declaramos una variable tipo tcplistener para escuchar las peticiones al servidor
        TcpListener server = null;
        //Declaramos una variable de tipo graphics
        Graphics grafico;

        public static System.Drawing.Point Position { get; set; }
        String mensajeRecibido;
        String mensajeTeclado;
        int evento;
        int teclaPresionada = 0;
        int clickEvento;
        private string queTeclaFue;
        //Agregamos la referencia user32 para definir la posicion del cursor
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        //Agregamos la referencia para definir el evento del mouse
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy,
        int cButtons, int dwExtraInfo);

        //Declaramos 2 constantes para controlar los clics del mouse
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //////VARIABLES//////////////////////
        ///

        //Esto simula un clic
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        private void compartePantalla()
        {
            while (true)
            {
                //version 2
                int i = 0;
                //Inicializamos una nueva instancia de MemoryStream
                ms = new MemoryStream();
                //Incializamos una nueva instancia de Bitmap y capturamos la pantalla
                imagenEscritorio = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics imagen = Graphics.FromImage(imagenEscritorio as Image);

                if (inicioCompartir)
                {
                    try
                    {

                        //Inicializo una nueva instancia de tcpClient
                        tcpClient = new TcpClient();
                        //Accedo al metodo tcpClient connect
                        tcpClient.Connect(nombreEquipo.Text, int.Parse(puerto.Text));

                        //Capturo la imagen de la pantalla
                        imagen.CopyFromScreen(0, 0, 0, 0, imagenEscritorio.Size);

                        //Dibujo el puntero del mouse en la posicion del mouse
                        imagen.DrawImage(Properties.Resources.mouse, Cursor.Position.X - 10, Cursor.Position.Y - 10);

                        //Creo un network stream para enviar y recibir datos
                        stream = tcpClient.GetStream();

                        //Guardo la imagen dentro del stream ms como jpeg
                        imagenEscritorio.Save(ms, ImageFormat.Jpeg);

                        //Los datos de la imagen los convierto a un arreglo
                        datosImagen = ms.ToArray();

                        //Envio los datos por medio del stream
                        stream.Write(datosImagen, 0, datosImagen.Length);

                        //Cambiamos la etiqueta label a conectado
                        estatusConexion.Text = "Conectado";
                    }
                    catch (ArgumentNullException e)
                    {
                        //MessageBox.Show("ArgumentNullException: {0} " + e);
                        valor = false;
                    }
                    catch (SocketException e)
                    {
                        // MessageBox.Show("SocketException: {0} " + e);
                        valor = false;
                    }

                    catch (Exception e)
                    {

                        // MessageBox.Show("No se pudo conectar " + e);
                        valor = false;
                    }
                }
                //Esperamos 10 milisegundos
                Thread.Sleep(10);
            }
        }



        private void visualizaPantalla()
        {
            //Creamos un bucle
            while (true)
            {
                //Validamos si inicio visualizar es True
                if (inicioVisualizar)
                {
                    try
                    {
                        //Creo el objeto tcp listener y defino el numero de puerto que aceptara conexiones
                        server = new TcpListener(IPAddress.Any, int.Parse(puerto.Text));
                        // inicio el servicio tcpListener
                        server.Start();

                        // Defino el buffer que almacenara los datos
                        byte[] bytes = new byte[277557];

                        // Si hay peticiones pendientes las acepto
                        tcpClient = server.AcceptTcpClient();
                        // creo un objeto de network stream para enviar o recibir datos
                        stream = tcpClient.GetStream();

                        //Defino i
                        int i;
                        //Leo el stream y lo asigno a la variable entero i
                        i = stream.Read(bytes, 0, 277557);

                        try
                        {
                            //Instanciamos un nuevo objeto de Memory Stream
                            ms = new MemoryStream(bytes);

                            //Asigno la imagen al picture box
                            pictureBox1.Image = Image.FromStream(ms);

                        }
                        catch (SocketException e)
                        {
                            // MessageBox.Show("Error Conexion" + e.ToString());
                        }

                        //vaciamos el MemoryStream
                        ms.Dispose();
                        //liberamos el network stream
                        stream.Dispose();
                        //Cerramos la conexion
                        tcpClient.Close();
                        //detenemos el servidor listener
                        server.Stop();
                    }
                    catch (SocketException e)
                    {
                        // MessageBox.Show("Error Conexion" + e.ToString());

                    }
                }
                //Esperamos 10 milisegundos antes de volver a iniciar el bucle
                Thread.Sleep(10);
            }
        }

        private void enviarPosicionMouse()
        {

            while (true)
            {
                // Instanciamos UdpClient y asignamos el puerto.
                UdpClient udpClient = new UdpClient(8082);
                try
                {
                    //Nos conectamos al equipo remoto con la IP y el puerto
                    udpClient.Connect(nombreEquipo.Text, 8082);

                    // Enviamos la posicion del puntero dentro del picture box.
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(pictureBox1.PointToClient(Cursor.Position).X + "-" + pictureBox1.PointToClient(Cursor.Position).Y + "-" + evento + "-" + Screen.PrimaryScreen.Bounds.X + "-" + Screen.PrimaryScreen.Bounds.Y + "-" + queTeclaFue + "-" + teclaPresionada);

                    //Enviamos los datos
                    udpClient.Send(sendBytes, sendBytes.Length);
                    //Cerramos la conexion UDP
                    udpClient.Close();
                    //Definimos a 0 evento que es el controla el clic del mouse
                    evento = 0;
                    teclaPresionada = 0;
                }
                catch (Exception e)
                {
                    //errores
                    // MessageBox.Show("Error: "+e);
                }
                //Esperamos 100 milisegundos
                Thread.Sleep(100);
            }

        }
        private void recibePosicionMouse()
        {
            while (true)
            {
                try
                {
                    // Instanciamos un objeto de udpcliente y asignamos el puerto
                    UdpClient udpClient = new UdpClient(8082);

                    //El objeto IPEndPoint nos permitirá leer los datagramas enviados desde cualquier fuente.
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                    // Bloquea hasta que vuelve un mensaje en este socket desde un host remoto..
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    //Recibimos los datos
                    string returnData = Encoding.ASCII.GetString(receiveBytes);

                    //Asignamos los datos recibidos a la variable mensaje recibido
                    mensajeRecibido = returnData.ToString();
                    //Cerramos la conexion
                    udpClient.Close();
                }
                catch (Exception e)
                {

                    // MessageBox.Show("Error:" + e);

                }
                Thread.Sleep(100);
            }

        }

        private void muevoCursor(String cadena)
        {

            try
            {
                // Cortamos la cadena recibida y creamos una arreglo
                String[] cadenaX = cadena.Split('-');
                //Declaramos las variables desde el arreglo
                int posicionX = int.Parse(cadenaX[0]);
                int posicionY = int.Parse(cadenaX[1]);
                int clickEvento = int.Parse(cadenaX[2]);
                int anchoPantalla = int.Parse(cadenaX[3]);
                int altoPantalla = int.Parse(cadenaX[4]);
                String teclaPulsada = cadenaX[5];
                int teclaPresionada = int.Parse(cadenaX[6]);

                //Movemos el puntero
                Cursor.Position = new Point(posicionX, posicionY);

                //Si hicimos click , simulamos el click del boton izquierdo del mouse en la posicion actual del puntero
                if (clickEvento == 1)
                {
                    LeftMouseClick(Cursor.Position.X, Cursor.Position.Y);
                    //Asignamos el clic evento a 0
                    clickEvento = 0;
                }
                if (teclaPresionada == 1)
                {

                    SendKeys.Send(teclaPulsada);

                }

            }
            catch
            {

            }
        }
        //
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inicioVisualizar == true)
            {
                teclaPresionada = 1;
                queTeclaFue = e.KeyChar.ToString();
            }
        }
        private void btnChat_Click(object sender, EventArgs e)
        {
            //Mostrar el chat
            Form2 h = new Form2();
            AddFormulario(h);
        }
        public void AddFormulario(Form f)
        {
            f.TopLevel = false;
            this.panel2.Controls.Add(f);
            f.Show();
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            //Cierra sesion
            this.Dispose();
        }

        private void btnCompartir_Click_1(object sender, EventArgs e)
        {
            //Cambio el valor de inicio compartir a true
            inicioCompartir = true;
            //Cambio la etiqueta a conectado
            estatusConexion.Text = "Conectado";

            //Creamos el delegado comparte pantalla
            ThreadStart delegado = new ThreadStart(compartePantalla);
            //Creamos la instancia del hilo
            Thread hilo = new Thread(delegado);
            //Declaramos el hilo como subproceso
            hilo.IsBackground = true;
            //Iniciamos el hilo
            hilo.Start();

            //Recibe posicion mouse
            //Creamos el delegado
            ThreadStart delegado4 = new ThreadStart(recibePosicionMouse);
            //Creamos la instancia del hilo
            Thread hilo4 = new Thread(delegado4);
            //Declaramos el hilo como subproceso
            hilo4.IsBackground = true;
            //Iniciamos el hilo
            hilo4.Start();
        }

        private void btnVisualizar_Click_1(object sender, EventArgs e)
        {
            //Cambio a true el valor de inicioVisualizar para que se inicie el proceso de visualizar pantalla
            inicioVisualizar = true;
            //Cambio la etiqueta de estatus a conectado
            estatusConexion.Text = "Conectado";

            //Creamos el delegado
            ThreadStart delegado1 = new ThreadStart(visualizaPantalla);
            //Creamos la instancia del hilo
            Thread hilo1 = new Thread(delegado1);
            //Declaramos el hilo como subproceso
            hilo1.IsBackground = true;
            //Iniciamos el hilo
            hilo1.Start();

            //Envia posicion mouse
            //Creamos el delegado
            ThreadStart delegado3 = new ThreadStart(enviarPosicionMouse);
            //Creamos la instancia del hilo
            Thread hilo3 = new Thread(delegado3);
            //Declaramos el hilo como subproceso
            hilo3.IsBackground = true;
            //Iniciamos el hilo
            hilo3.Start();
        }

        private void btnDetener_Click_1(object sender, EventArgs e)
        {
            //detenemos los procesos
            inicioVisualizar = false;
            inicioCompartir = false;

            //Eliminados el contenido de picture box
            pictureBox2.Image = null;
            //Cambiamos el estatus a desconectado la etiqueta de estatus
            estatusConexion.Text = "Desconectado";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (inicioCompartir && inicioVisualizar == false)
            {
                try
                {
                    muevoCursor(mensajeRecibido);
                    teclaPresionada = 0;
                    clickEvento = 0;
                }
                catch
                {
                }

            }
            if (inicioVisualizar && inicioCompartir == false)
            {
                //Inicio el proceso de visualizar pantalla cada 100 milisegundos
                // visualizaPantalla();
                // enviarPosicionMouse();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //Asignamos el valor de 1 a evento del click
            evento = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
