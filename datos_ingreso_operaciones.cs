using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace trabajo_final
{
    
    internal class datos_ingreso_operaciones
    {

        public static int AgregarSolicitud(datos_ingreso datosIngreso)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into formulario_ingreso values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", datosIngreso.documento, datosIngreso.tipo_documento, datosIngreso.nombre, datosIngreso.apellido,
                datosIngreso.direccion, datosIngreso.telefono, datosIngreso.fecha_nacimiento, datosIngreso.observaciones, datosIngreso.estado), bdcomun.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }        

        public static List<datos_ingreso> BuscarSolicitante(string documento)
        {
            List<datos_ingreso> _lista = new List<datos_ingreso>();

            MySqlCommand _comando = new MySqlCommand(string.Format("select *  from formulario_ingreso where documento = '{0}'", documento), bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                datos_ingreso pclientelocal = new datos_ingreso();
                pclientelocal.documento = _reader.GetInt32(0);
                pclientelocal.tipo_documento = _reader.GetString(1);
                pclientelocal.nombre = _reader.GetString(2);
                pclientelocal.apellido = _reader.GetString(3);
                pclientelocal.direccion = _reader.GetString(4);
                pclientelocal.telefono = _reader.GetString(5);
                pclientelocal.fecha_nacimiento = _reader.GetString(6);
                pclientelocal.observaciones = _reader.GetString(7);
                pclientelocal.estado = _reader.GetString(8);

                _lista.Add(pclientelocal);
            }

            return _lista;
        }

        public static List<datos_ingreso> BuscarSolicitantes()
        {
            List<datos_ingreso> _lista = new List<datos_ingreso>();

            MySqlCommand _comando = new MySqlCommand(string.Format("select documento,nombre,apellido,direccion,telefono,observaciones,estado  from formulario_ingreso where estado = ''"), bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                datos_ingreso pclientelocal = new datos_ingreso();
                pclientelocal.documento = _reader.GetInt32(0);
                pclientelocal.nombre = _reader.GetString(1);
                pclientelocal.apellido = _reader.GetString(2);
                pclientelocal.direccion = _reader.GetString(2);
                pclientelocal.telefono = _reader.GetString(2);
                pclientelocal.observaciones = _reader.GetString(3);
                pclientelocal.estado = _reader.GetString(4);

                _lista.Add(pclientelocal);
            }

            return _lista;
        }

        public static int AgregarMensualidad(mensualidad pago)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into mensualidades values ('{0}','{1}','{2}','{3}')", pago.identificacion, pago.nombre, pago.mes, pago.valor), bdcomun.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<mensualidad> BuscarMensualidades()
        {
            List<mensualidad> _lista = new List<mensualidad>();

            MySqlCommand _comando = new MySqlCommand(string.Format("select *  from mensualidades"), bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                mensualidad mensualidadR = new mensualidad();
                mensualidadR.identificacion = _reader.GetInt32(0);
                mensualidadR.nombre = _reader.GetString(1);
                mensualidadR.mes = _reader.GetString(2);
                mensualidadR.valor = _reader.GetString(3);

                _lista.Add(mensualidadR);
            }

            return _lista;
        }

        public static int AgregarInventario(Inventario1 inventario)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into inventarios values ('{0}','{1}','{2}','{3}','{4}')", inventario.ID, inventario.nombre, inventario.cantidad, inventario.costou, inventario.costot), bdcomun.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Inventario1> BuscarInventario(String Id)
        {
            List<Inventario1> _lista = new List<Inventario1>();

            MySqlCommand _comando = new MySqlCommand(string.Format("select nombreprod,cantidadprod,costouni  from inventarios where IDprod = '{0}'",Id), bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Inventario1 inventario1 = new Inventario1();
                inventario1.nombre = _reader.GetString(0);
                inventario1.cantidad = _reader.GetString(1);
                inventario1.costou = _reader.GetInt32(2);

                _lista.Add(inventario1);
            }

            return _lista;
        }

        public static int ModificarInventario(Inventario1 inventario)
        {
            int resultado = 0;
            string cadena = "";
            cadena = "update inventarios set nombreprod = '{1}', cantidadprod = '{2}', costouni = '{3}', costototal = {4} where IDprod = {0}";
            MySqlCommand comando = new MySqlCommand(string.Format(cadena, inventario.ID, inventario.nombre, inventario.cantidad, inventario.costou, inventario.costot), bdcomun.obtenerconexion());
            resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public static List<Inventario1> MostrarProductos()
        {
            List<Inventario1> _lista = new List<Inventario1>();

            MySqlCommand _comando = new MySqlCommand(string.Format("select *  from inventarios"), bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Inventario1 inventario1 = new Inventario1();
                inventario1.ID = _reader.GetInt32(0);
                inventario1.nombre = _reader.GetString(1);
                inventario1.cantidad = _reader.GetString(2);
                inventario1.costou = Convert.ToInt32(_reader.GetString(3));
                inventario1.costot = Convert.ToInt32(_reader.GetString(4));

                _lista.Add(inventario1);
            }

            return _lista;
        }

        public static List<Inventario1> EliminarProducto(string pcedula)
        {
            List<Inventario1> _lista = new List<Inventario1>();

            MySqlCommand _comando = new MySqlCommand(string.Format("delete from inventarios where IDprod = '{0}'", pcedula), bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Inventario1 inventario1 = new Inventario1();
                inventario1.ID = _reader.GetInt32(0);
                inventario1.nombre = _reader.GetString(1);
                inventario1.cantidad = _reader.GetString(2);
                inventario1.costou = Convert.ToInt32(_reader.GetString(3));
                inventario1.costot = Convert.ToInt32(_reader.GetString(4));

                _lista.Add(inventario1);
            }

            return _lista;
        }

        public static int AgregarNomina(nomina1 datosIngreso)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into nomina values ('{0}','{1}','{2}','{3}','{4}')", datosIngreso.cedula, datosIngreso.nombre, datosIngreso.periodo, datosIngreso.deduciones,
                datosIngreso.total), bdcomun.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<nomina1> BuscarNomina()
        {
            List<nomina1> _lista = new List<nomina1>();

            MySqlCommand _comando = new MySqlCommand(string.Format("select *  from nomina"), bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                nomina1 nomina = new nomina1();
                nomina.cedula = _reader.GetInt32(0);
                nomina.nombre = _reader.GetString(1);
                nomina.periodo = _reader.GetString(2);
                nomina.deduciones = _reader.GetString(3);
                nomina.total = _reader.GetString(4);

                _lista.Add(nomina);
            }

            return _lista;
        }

        public static int ModificarSolicitud(datos_ingreso datoIngreso)
        {
            int resultado = 0;
            string cadena = "";
            cadena = "update formulario_ingreso set estado = '{1}' where documento = {0}";
            MySqlCommand comando = new MySqlCommand(string.Format(cadena, datoIngreso.documento, datoIngreso.estado), bdcomun.obtenerconexion());
            resultado = comando.ExecuteNonQuery();
            return resultado;
        }

    }
}
