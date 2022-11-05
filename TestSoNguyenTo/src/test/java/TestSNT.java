
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Tag;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvFileSource;
import org.junit.jupiter.params.provider.CsvSource;
import org.junit.jupiter.params.provider.ValueSource;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author admin
 */
public class TestSNT {
    @Test
    @Tag("Critial")
    @DisplayName("Kiem tra so nguyen to le")
    public void testSoLe()
    {
        int n = 5;
        boolean expected = true;
        boolean actual = Utils.ktNt(n);
        Assertions.assertEquals(expected,actual);
    }
     @Test
    public void testSoChan()
    {
        int n = 2;
        boolean expected = true;
        boolean actual = Utils.ktNt(n);
        Assertions.assertEquals(expected,actual);
    }
    @ParameterizedTest
    @ValueSource(ints={2,5,7,97,103})
    public void testTrue(int n)
    {
        Assertions.assertTrue(Utils.ktNt(n), "Cuong");
    }
    //Test 1 tap gia tri khac nhau
    @ParameterizedTest
    @CsvSource({"1,false,chuoiTB1", "2,true,chuoiTB2", "4,false,chuoiTB3"})
    public void testAllValue(int n, boolean expected, String mess)
    {
        boolean actual ;
        actual = Utils.ktNt(n);
        Assertions.assertEquals(expected, actual, mess);
    }
    //Test 1 tap gia tri doc tu file csv
    @ParameterizedTest
    @CsvFileSource(files="src/main/resource/Data.csv",numLinesToSkip=0)
    public void testFile(int n, boolean expected, String mess)
    {
        boolean actual ;
        actual = Utils.ktNt(n);
        Assertions.assertEquals(expected, actual, mess);
    }
    
    //Test Exception
    @Test
    public void testException()
    {
        int n = -3;
        Assertions.assertThrows(ArithmeticException.class,()-> {Utils.ktNt(n);});
    }
}
