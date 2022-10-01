void GetArray()
      {  
      Console.WriteLine("Введите количество элементов в массиве N:");
      int N = int.Parse(Console.ReadLine());
      
      string[] arr = new string[N];
      
      Console.WriteLine("Введите элементы массива:");

      for (int i = 0; i < N; i++)
      {
        arr[i] = Console.ReadLine();
      }
           
      string [] arr2 = new string[N];      
      
      int k = 0;
      
      for (int i = 0; i < N; i++)
      
        {
        int length = arr[i].Length;    
               
        if (length <= 3)
          {     
            arr2[k] = arr[i];
            k++;
          }
          
        }

      Console.Write($"['{string.Join("', '", arr)}']");
      Console.WriteLine();
      
      Array.Resize(ref arr2, k);  
      Console.Write($"['{string.Join("', '", arr2)}']");
      Console.WriteLine();
      }

      GetArray();
      