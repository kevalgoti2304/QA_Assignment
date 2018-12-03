package com.example.kevalgoti.assignment03;

import org.junit.Test;

import static org.junit.Assert.*;

public class CalculatorTest {
    Calculator c = new Calculator();

    // TEST CASES FOR ADDITION

    @Test
    public void testAddition_inputNegativeTenAndNegativeTwenty_outputNegativeThirty() {
        // 1. Arrange
        double i = -10;
        double j = -20;

        // 2. Act
        double result = c.addition(i, j);

        // 3. Assert
        assertEquals(-30.0, result,1);
    }

    @Test
    public void testAddition_inputThreeAndNegativeTwoPointFive_outputZeroPointFive(){
        // 1. Arrange
        double i = 3.0;
        double j = -2.5;

        // 2. Act
        double result = c.addition(i, j);

        // 3. Assert
        assertEquals(0.5, result, 1);
    }

    @Test
    public void testAddition_inputNegativeFiveAndNegativeThreePointSix_outputEightPointSix(){
        // 1. Arrange
        double i = -5.0;
        double j = -3.6;

        // 2. Act
        double result = c.addition(i, j);

        // 3. Assert
        assertEquals(-8.6, result, 1);
    }

    // TEST CASES FOR SUBTRACTION

    @Test
    public void testSubtraction_inputNegativeTwentyAndTen_outputNegativeThirty(){
        // 1. Arrange
        double i = -20.0;
        double j = 10.0;

        // 2. Act
        double result = c.subtraction(i, j);

        // 3. Assert
        assertEquals(-30.0, result, 1);
    }
    @Test
    public void testSubtraction_inputNegativeSevenAndNegativeOne_outputNegativeEight(){
        // 1. Arrange
        double i = -7.0;
        double j = -1.0;

        // 2. Act
        double result = c.subtraction(i, j);

        // 3. Assert
        assertEquals(-6.0, result, 1);
    }
    @Test
    public void testSubtraction_inputNegativeFiveAndZeroPointFive_outputNegativeFivePointFive(){
        // 1. Arrange
        double i = -5;
        double j = 0.5;

        // 2. Act
        double result = c.subtraction(i, j);

        // 3. Assert
        assertEquals(-5.5, result, 1);
    }

    // TEST CASES FOR MULTIPLICATION

    @Test
    public void testMultiplication_inputNegativeTwentyAndNegativeThree_outputSixty(){
        // 1. Arrange
        double i = -20;
        double j = -3;

        // 2. Act
        double result = c.multiplication(i, j);

        // 3. Assert
        assertEquals(60.0, result, 1);
    }
    @Test
    public void testMultiplication_inputNegativeTwoPointThreeAndThree_outputSixPointNine(){
        // 1. Arrange
        double i = -2.3;
        double j = 3;

        // 2. Act
        double result = c.multiplication(i, j);

        // 3. Assert
        assertEquals(-6.9, result, 1);
    }
    @Test
    public void testMultiplication_inputZeroAndNegativeOnePointFive_outputZero(){
        // 1. Arrange
        double i = 0;
        double j = -1.5;

        // 2. Act
        double result = c.multiplication(i, j);

        // 3. Assert
        assertEquals(0.0, result, 1);
    }
    // TEST CASES FOR DIVISION

    @Test
    public void testDivision_inputTenAndTwoPointFive_outputFour(){
        // 1. Arrange
        double i = 10;
        double j = 2.5;

        // 2. Act
        double result = c.division(i, j);

        // 3. Assert
        assertEquals(4.0, result, 1);
    }
    @Test
    public void testDivision_inputNegativeFiveAndTwo_outputTwoPointFive(){
        // 1. Arrange
        double i = -5;
        double j = 2;

        // 2. Act
        double result = c.division(i, j);

        // 3. Assert
        assertEquals(-2.5, result, 1);
    }
    @Test
    public void testDivision_negativeSixAndNegativeThree_outputTwo(){
        // 1. Arrange
        double i = -6;
        double j = -3;

        // 2. Act
        double result = c.division(i, j);

        // 3. Assert
        assertEquals(2.0, result, 1);
    }

    // TEST CASES FOR DIVISION Que 7

    @Test
    public void testDivision_1and1_output1(){
        // 1. Arrange
        double i = 1;
        double j = 1;

        // 2. Act
        double result = c.division(i, j);

        // 3. Assert
        assertEquals(1.0, result, 1);
    }
    @Test
    public void testDivision_2and1_output1(){
        // 1. Arrange
        double i = 2;
        double j = 1;

        // 2. Act
        double result = c.division(i, j);

        // 3. Assert
        assertEquals(2.0, result, 1);
    }
    @Test
    public void testDivision_9and3_output1(){
        // 1. Arrange
        double i = 9;
        double j = 3;

        // 2. Act
        double result = c.division(i, j);

        // 3. Assert
        assertEquals(3.0, result, 1);
    }

}