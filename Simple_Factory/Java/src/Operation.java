public class Operation {
        protected double _numberA, NumberA;
        protected double _numberB, NumberB;

        public void setNumberA(double value){
                _numberA = value;
                // Add some conditions to set public numberA
                NumberA = _numberA;
        }

        public double getNumberA(){
                return NumberA;
        }
        
        public void setNumberB(double value){
                _numberB = value;
                // Add some conditions to set public numberB
                NumberB = _numberB;
        }

        public double getNumberB(){
                return NumberB;
        }

        public double GetResult() throws Exception{
                return 0;
        }
}