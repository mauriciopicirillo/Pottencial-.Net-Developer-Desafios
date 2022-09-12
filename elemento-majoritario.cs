//  Desafio
// Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.

// Entrada
// A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas nums serão os valores da sua array.

// Saída
// A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.

// Exemplo 1

// Entrada	Saída
// 3
// 7
// 5
// 7	7
// Exemplo 2

// Entrada	Saída
// 9
// 2
// 1
// 1
// 1
// 2
// 2
// 2
// 1
// 2	2

using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int contador = 0; contador < num.Length; contador ++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums, int major)
    {
        int major = nums[0];
        int count = 0;
        for (int i = 0; i < n; count++)
        {
            if ( nums[i] == nums[major])
            {
                major = nums[i];
                count++;
            }
            else
            {
                if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return          ;
    }
}