using System;

abstract class CashSuper{
	 public abstract double acceptCash(double money);
}

class CashNormal : CashSuper{
	public override double acceptCash(double money){
		return money;
	}
}

class CashRebate : CashSuper{
	private double moneyRebate = 1d;

	public CashRebate(string moneyRebate){
		this.moneyRebate = double.Parse(moneyRebate);
	}

	public override double acceptCash(double money){
		return money * moneyRebate;
	}
}

class CashReturn : CashSuper{
	private double moneyCondition = 0.0d;
	private double moneyReturn = 0.0d;

	public CashReturn(string moneyCondition, string moneyReturn){
		this.moneyCondition = double.Parse(moneyCondition);
		this.moneyReturn = double.Parse(moneyReturn);
	}

	public override double acceptCash(double money){
		double result = money;
		if (money >= moneyCondition){
			result = money - Math.Floor(money / moneyCondition) * moneyReturn;
		}
		return result;
	}
}

// Simple Factory
class CashFactory{
	public static CashSuper createCashAccept(string type){
		CashSuper cs = null;

		switch(type){
			case "Normal":
				cs = new CashNormal();
				break;
			case "300 Return 100":
				cs = new CashReturn("300", "100");
				break;
			case "80% discount":
				cs = new CashRebate("0.8");
				break;
		}
		return cs;
	}
}

// Client for Simple Factory
public class Class1{
	public static void Main1(string[] args){
		double total = 0.0d;
		CashSuper csuper = CashFactory.createCashAccept("80% discount");
		double totalPrices = csuper.acceptCash(288 * 3);
		total = total + totalPrices;
		Console.WriteLine("Result : {0}", total);
	}
}

// Strategy
class CashContext{
	private CashSuper cs;

	public CashContext(CashSuper csuper){
		this.cs = csuper;
	}

	public double GetResult(double money){
		return cs.acceptCash(money);
	}
}

// Client for Strategy
public class Class2{
	public static void Main2(string[] args){
		CashContext cc = null;
		string input = "Normal";
		switch (input){
			case "Normal":
				cc = new CashContext(new CashNormal());
				break;
			case "300 Return 100":
				cc = new CashContext(new CashReturn("300", "100"));
				break;
			case "80% discount":
				cc = new CashContext(new CashRebate("0.8"));
				break;
		}
		double total = 0.0d;
		double totalPrices = cc.GetResult(288 * 3);
		total += totalPrices;
		Console.WriteLine("Result2 : {0}", total);
	}
}

// Strategy + Simple Factory
class CashContextFactory{
	CashSuper cs = null;

	public CashContextFactory(string type){
		switch(type){
			case "Normal":
				cs = new CashNormal();
				break;
			case "80% discount":
				cs = new CashRebate("0.8");
				break;
			case "300 Return 100":
				cs = new CashReturn("300", "100");
				break;
		}
	}

	public double GetResult(double money){
		return cs.acceptCash(money);
	}
}

// Client for Strategy + Simple_Factory
public class Class3{
	public static void Main (string[] args){
		double total = 0.0d;
		CashContextFactory csuper = new CashContextFactory("Normal");
		double totalPrices = csuper.GetResult(288 * 3);
		total += totalPrices;
		Console.WriteLine("Result3: {0}", total);
	}
}