using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    public enum EstadoEncomiendaEnum
    {
        ImpuestaPendienteRetiroDomicilio, //cuando se impone en CC 0 
        ImpuestaPendienteRetiroAgencia, //cuando se impone en agencia 1
        RuteadaRetiroDomicilio, //Desde el CD le indico al fletero que tiene que ir a buscar encomiendas pendiente retiro domicilio 2
        RuteadaRetiroAgencia, //Desde el CD le indico al fletero que tiene que ir a buscar encomiendas pendiente retiro agencia 3
        EnTransitoUMOrigen, //Fletero pasó por el CD, y está yendo a buscar ruteadasdomicilio y ruteadasagencia 4
        Admitida, //Fletero llegó del domicilio/agencia y la encomienda fue admitida en CD Origne 5 
        EnTransitoMD, //Encomeindas admitidas en CD Origen y están en tránsito hacia CD Destino  6 Esto es cuando pasa a ser ruteada, no? es en la pantalla de rodri
        //EnCDDestino, //Despachas en CD , esperando retiro o distribución UM, no sería necesario este estado
        PendienteRetiroCD, //7
        PendienteEntregaDomicilio,//8
        PendienteEntregaAgencia,//9
        //se podrían resumir en PendienteEntregaUM ?
        //RuteadaUM, //no necesario
        //quedan en CD hasta que pasa fletero y armo HDR distribucion UM
        EnTransitoUMDestino, //10Fletero pasó por el CD Destino y está yendo a entregar encomiendas pendiente entrega domicilio/agencia
        PendienteRetiroAgencia,  //11Fletero entrega en agencia, esperando que el cliente retire
        Entregada, //12sea en casa, agencia o CD ? 
        NoEntregada, //13sumo este caso momentaneamente para manejar las devoluciones de entrega
        Cancelada
    }
}


/*ideal si tuviesemos un menu donde al inicio ya te dice donde está la encomienda. 
        Impuesta,
        Ruteada, 
        Admitida,
        EnTransitoMD,
        EnCDDestino,
        PendienteEntrega,
        RuteadaUM,
        PendienteRetiroCD,
        PendienteRetiroAgencia, 
        Entregada,
        Cancelada
        */
5 Admitida-- donde se genera DatosFacturacion rendicionFletero (GestionarFletero despues de aceptar)
Acá se asigna a una HDR de MD con EnCDDestino
6 EnTransitoMD  omnibus (GEstionarOminbus dsp de aceptar) - aparace en encomiendas a subir
7 PendienteRetiroEnCD  omnibus (GEstionarOminbus dsp de aceptar) - aparace en encomiendas a bajar
12 Entragada - RetirarEnCd - dsp de entregarEncomienda