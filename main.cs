using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    int[] saldos = {1000, 2300, -100, 300};

    Credito(saldos);
    foreach(int i in saldos){
      Console.WriteLine(i);
    }
  }

//array contiene saldos de 4 clientes
//crear metodo para asignar un credito de 200 soles al saldo
  static void Credito(int[] arrSaldos){
    int credito = 200; 
    for(int i = 0; i < arrSaldos.Length; i++){
      //toma el array, y al indice del array le va a sumar 200
      arrSaldos[i] += credito; 
    }
  }

}
