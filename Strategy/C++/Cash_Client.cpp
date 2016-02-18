#include <iostream>

using namespace std;

class CashSuper{
public:
	virtual double acceptCash(double money){
		return money;
	}
};

class CashNormal : public CashSuper{
public:
	double acceptCash(double);
};

double CashNormal::acceptCash(double money) {
	return money;
}

class CashRebate : public CashSuper{
private:
	double moneyRebate;

public:
	CashRebate(string moneyRebate){
		this -> moneyRebate = stod(moneyRebate);
	}

	double acceptCash(double);
};


double CashRebate::acceptCash(double  money){
	return money * moneyRebate;
}


class CashReturn : public CashSuper{
private:
	double moneyCondition;
	double moneyReturn;
public:
	CashReturn(string moneyCondition, string moneyReturn){
		this -> moneyCondition = stod(moneyCondition);
		this -> moneyReturn = stod(moneyReturn);
	}

	double acceptCash(double money){
		double result = money;
		if (money >= moneyCondition){
			result = money - float(money / moneyCondition) * moneyReturn;
		}
		return result;
	}
};


class CashContextFactory{
private:
	CashSuper *cs;
public:
	CashContextFactory(string type){
		if (type == "Normal"){
			cs = new CashNormal();
		}
		else if (type == "80%% discount"){
			cs = new CashRebate("0.8");
		}
		else if (type == "300 Return 100"){
			cs = new CashReturn("300", "100");
		}
	}

	double GetResult(double);
};

double CashContextFactory::GetResult(double money){
	return cs -> acceptCash(money);
}

int main(void){
	CashContextFactory cs("80%% discount");
	double totalPrices = cs.GetResult(288 * 3);
	cout << "Result3: " << totalPrices << endl;
	return 0;
}