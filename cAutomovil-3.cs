﻿using System;
namespace Ejercicio_Automovil
{
    public class cAutomovil
    {
        //Atributos = caracteristicas de la clase (se traducen en variables)
        string _modelo, _marca, _year, _color, _tipo, _tipoCombustible, _transmision;
        bool _es4x4;

        string mensajeGasolina, mensajeEncendido, mensajeCambioLLanta, colorNuevo, fasePintura;
        bool comprarLlanta, cambiarColor, elegircolor;

        //Constructor = Instanciar la clase desde fuera.
        //Al crear un objeto de la clase se pueden instanciar a cero o
        //limpiar las variables que se utilizan en la clase o incluso recibir datos
        public cAutomovil()
        {
            _modelo = "";
            _marca = "";
            _year = "";
            _color = "";
            _tipo = "";
            _tipoCombustible = "";
            _transmision = "";
            _es4x4 = false;
        }


        //Metodos de Get y Set

        /// <summary>
        /// Metodo de Set para asignar valor proveniente del main
        /// </summary>
        /// <param name="modelo"></param>
        public void setModelo(string modelo)
        {
            _modelo = modelo;
        }

        /// <summary>
        /// Metodo para retornar al main valores propios de la clase
        /// </summary>
        /// <returns>_modelo</returns>
        public string getModelo()
        {
            return _modelo;
        }


        public string getLLenarTanque()
        {
            return mensajeGasolina;
        }

        public string getcambiarColor()
        {
            return mensajecambiarColor;
        }

        //Metodos = acciones que se realizan en la clase

        void metodoClase()
        {



        }

        void metodoUber()
        {


        }

        void metodoTaxi()
        {
        }


        void metodoDeportivo()
        {
        }

        

        void necesitaCambiaLLanta(string estadoLlanta)
        {

            //estado llanta = lisa, pinchada, desinflada, normal

            switch (estadoLlanta.ToLower())
            {

                case "lisa":
                    comprarLlanta = true;
                    cambiarLlanta(estadoLlanta.ToLower());
                    break;
                case "pinchada":
                    comprarLlanta = false;
                    cambiarLlanta(estadoLlanta.ToLower());
                    break;
                case "desinflado":
                    comprarLlanta = false;
                    cambiarLlanta(estadoLlanta.ToLower());
                    break;
                case "normal":
                    mensajeCambioLLanta = "Llanta en condiciones estables";
                    break;

                default:
                    break;
            }

        }

        void cambiarColor()
        {

            //lijar, masilla, color gris, pulir, pintar

            fasePintura = "inicio";

            while (fasePintura = !"terminado")
            {
                switch (fasePintura .ToLower())
                {

                    case "lijar":
                        fasePintura  = "lijar automovil";
                        break;
                    case "masilla":

                        cambiarColor = false;
                        cambiarColor(elegirColor.ToLower());
                        break;
                    case "color gris":
                        cambiarColor  = false;
                        cambiarColor (elegirColor.ToLower());
                        break;
                    case "pulir":
                        cambiarColor = "Llanta en condiciones estables";
                        break;

                    case "pintar":
                          = "Llanta en condiciones estables";
                        break;

                    default:
                        break;
                }


            }




        }


        string elegirColor()
        {

            //variables colores
            string color;
            //recibir respueste del usuario del color
            //regresar color al metodo original

            return color;

        }

        void cambiarLlanta(string estado)
        {

            if (comprarLlanta == true && estado == "lisa")
            {
                mensajeCambioLLanta = "Debe de comprar llanta e instalarla";
            }
            else
            {
                if (comprarLlanta == false && estado == "pinchada")
                {
                    mensajeCambioLLanta = "Debe de comprar reparar la llanta";

                }
                else
                {
                    if (comprarLlanta == false && estado == "desinflada")
                    {

                        mensajeCambioLLanta = "Debe de comprar inflar la llanta";

                    }
                }
            }




        }


        void llenarTanque(string nivelGasolina)
        {
            //medio tanque = tiene que llenar

            if (nivelGasolina == "medio tanque")
            {
                mensajeGasolina = "Debe de llenar el tanque";
            }
            else
            {
                mensajeGasolina = "Nivel de gasolina es suficiente, no debe de llenar";

            }

        }

        void arrancarCarro(bool motorEncendido)
        {
            if (motorEncendido == true)
            {
                mensajeEncendido = "Vehiculo encendido";
            }
            else
            {
                mensajeEncendido = "Vehiculo apagado, proceder a encenderlo";
            }
        }

    }
}


