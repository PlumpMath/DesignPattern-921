

public class OperationFactory{
        public static Operation createOperation(String operation){
                Operation oper = null;
                
                if (operation == "+"){
                        oper = new OperationAdd();
                }
                else if (operation == "-"){
                        oper = new OperationSub();
                }
                else if (operation == "*"){
                        oper = new OperationMul();
                }
                else if (operation == "/"){
                        oper = new OperationDiv();
                }
                return oper;
        }
}