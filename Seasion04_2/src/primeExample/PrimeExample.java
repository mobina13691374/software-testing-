package primeExample;

public class PrimeExample {
	static public int IsPrime(int a)
	{
		int i,m=0;
		m=a/2; 
		if(a==0||a==1)
		{  
			return 0;      
		}
		else{  
			for(i=2;i<=m;i++){
				if(a%i==0){  
					return 0;          
				}
			}     
			return 1;  
		}
	}   

}