using System;
	 namespace Bills
	 {
    		public struct Bill_Details 
    		{
		        public string bill_No;
		        public string ord_Dt;
		        public string custName;
		        public string product;
		        public double cost;
		        public double advance_Amt;
		        public double due_Amt;
	 }
	 	class TestStructure 
   		 {
      	public static void Main(string[] args)
       {
	       Bill_Details billObj = new Bill_Details();
		   billObj.bill_No = "A101";
		   billObj.ord_Dt = "10/10/06";
		   billObj.custName = "Joe";
		   billObj.product = "Petrol";
		   billObj.cost = 100;
		   billObj.advance_Amt = 50;
		   billObj.due_Amt = 50;
	        Console.Clear();
	    Console.WriteLine("Bill Number is {0}“, 	billObj.bill_No);
       Console.WriteLine("Order Date is {0}“, 	billObj.ord_Dt);
       Console.WriteLine("Customer Name is {0}“,    
       billObj.custName);
       Console.WriteLine("Product is {0}“, 	billObj.product);
       Console.WriteLine("Cost is {0}“, 	billObj.cost);
	    Console.WriteLine("Advance Amount is {0}", 	billObj.advance_Amt);
       Console.WriteLine("Due Amount is {0}“, 	billObj.due_Amt);
      }
   } }
                    

                    

