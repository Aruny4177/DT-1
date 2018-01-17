using System;
using System.Collection.Generic;
using Sytstem.Text;

namespace Divisible
{
	class product_Even
	{
		static void Main(string[ ] args)
		{
			int nNum, nEven;
  			double n Prod;
			nNum=2; nEven=0; nProd=1;
			While (nEven < 10)
			{
				nProd = nNum * nProd;
				nNum = nNum + 2;
				nEven = nEven + 1;
			}
	Console.WriteLine("the product of first 10 even number is even:{0}",nProd);
		}
	}
}
