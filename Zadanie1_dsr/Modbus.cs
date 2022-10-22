using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
 

namespace Zadanie1_dsr
{
    class Modbus
    {
        private IPAddress ipAddress;
        private int port;
        private TcpClient client;
        private NetworkStream stream;
        private int transId;

        public Modbus(string ipAddress, int port)
        {
            this.ipAddress = IPAddress.Parse(ipAddress);
            this.port = port;
            client = new TcpClient();
            transId = 0;
        }

        public bool Connect()
        {
            try
            {
                client.Connect(ipAddress, port);
                stream = client.GetStream();
                return true;
            }
            catch(Exception exception)
            {
                Console.Out.WriteLine(exception.ToString());
               // MessageBox.Show("Please fill in the correct IP address and port number!");
                return false;
            }
        }

        public void Disconnect()
        {
            if (client.Connected)
            {
                stream.Close();
                client.Close();
            }
        }

        public int ReadInputRegister(int addr)
        {
            Byte[] request = new Byte[12];
            
            transId++;
            request[0] = (byte)((transId >> 8) & 0xFF); //transaaction ID
            request[1] = (byte)(transId & 0xFF);

            request[2] = 0; //protocol identifier
            request[3] = 0;

            request[4] = 0; //length
            request[5] = 6;

            request[6] = 1; //unit id
            request[7] = 4; //function code

            addr--;
            request[8] = (byte)((addr >> 8) & 0xFF); //register address
            request[9] = (byte)(addr & 0xFF);

            request[10] = 0;
            request[11] = 1;

            stream.Write(request, 0, request.Length); //send request

            Byte[] response = new Byte[16];
            int respSize = stream.Read(response, 0, 16);
            if (respSize > 0)
            {
                return (int)(response[9] << 8) | (int)response[10];
            }

            return -1;
        }

        public bool WriteHoldingRegister(int addr, int value)
        {
            Byte[] request = new Byte[12];

            transId++;
            request[0] = (byte)((transId >> 8) & 0xFF); //transaaction ID
            request[1] = (byte)(transId & 0xFF);

            request[2] = 0; //protocol identifier
            request[3] = 0;

            request[4] = 0; //length
            request[5] = 6;

            request[6] = 1; //unit id
            request[7] = 6; //function code

            addr--;
            request[8] = (byte)((addr >> 8) & 0xFF); //register address
            request[9] = (byte)(addr & 0xFF);

            request[10] = (byte)((value >> 8) & 0xFF); 
            request[11] = (byte)(value & 0xFF);

            stream.Write(request, 0, request.Length); //send request

            Byte[] response = new Byte[16];
            int respSize = stream.Read(response, 0, 16);
            if (respSize > 0)
            {
                return request[10] == response[10] && request[11] == response[11];
            }

            return false;
        }


        public int ReadDiscreteInput(int addr)
        {
            Byte[] request = new Byte[12];

            transId++;
            request[0] = (byte)((transId >> 8) & 0xFF); //transaction ID
            request[1] = (byte)(transId & 0xFF);

            request[2] = 0; //protocol identifier
            request[3] = 0;

            request[4] = 0; //length
            request[5] = 6;

            request[6] = 1; //unit id
            request[7] = 2; //function code

            addr--;
            request[8] = (byte)((addr >> 8) & 0xFF); //register address
            request[9] = (byte)(addr & 0xFF);

            request[10] = 0;
            request[11] = 1;

            stream.Write(request, 0, request.Length); //send request

            Byte[] response = new Byte[16];
            int respSize = stream.Read(response, 0, 16);
            if (respSize > 0)
            {
                //Console.WriteLine((int)(response[9])); //| (int)response[10]);
                return (int)(response[9]);
            }

            return -1;
        }

        public bool WriteCoil(int addr, int value)
        {
            Byte[] request = new Byte[12];

            transId++;
            request[0] = (byte)((transId >> 8) & 0xFF); //transaaction ID
            request[1] = (byte)(transId & 0xFF);

            request[2] = 0; //protocol identifier
            request[3] = 0;

            request[4] = 0; //length
            request[5] = 6;

            request[6] = 1; //unit id
            request[7] = 5; //function code

            addr--;
            request[8] = (byte)((addr >> 8) & 0xFF); //register address
            request[9] = (byte)(addr & 0xFF);

            request[10] = (byte)((value >> 8) & 0xFF);
            request[11] = (byte)(value & 0xFF);

            stream.Write(request, 0, request.Length); //send request

            Byte[] response = new Byte[16];
            int respSize = stream.Read(response, 0, 16);
            if (respSize > 0)
            {
               // Console.WriteLine((int)((response[11] << 8) & 0xFF));
               // Console.WriteLine((int)((request[11] << 8) & 0xFF));
                return request[10] == response[10] && request[11] == response[11];
            }

            return false;
        }
    }


}
