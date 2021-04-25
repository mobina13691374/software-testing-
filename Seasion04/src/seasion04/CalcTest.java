package seasion04;

import static org.junit.Assert.*;

import org.junit.*;

public class CalcTest {
	
	@Test public void testAdd() 
	{
		assertEquals (5,Calc.add(2, 3));
	}

	@Test public void testMul()
	{
		assertEquals (6,Calc.mul(2, 3));
	}
	
	@Test
	public void test() {
		fail("Not yet implemented");
	}

}
