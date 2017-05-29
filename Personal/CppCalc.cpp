// Svetlio.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;


int main()
{

	int firstNumber, secondNumber;

	char operationSymbol;

	cout << "Enter fisrt number" << endl;
	cin >> firstNumber;

	cout << "Chose operaton + - * /" << endl;
	cin >> operationSymbol;

	cout << "Enter second number" << endl;
	cin >> secondNumber;

	if (operationSymbol == '+')
	{
		cout << "Result is " << firstNumber + secondNumber << endl;
	}
	else if (operationSymbol == '-')
	{
		cout << "Result is " << firstNumber - secondNumber << endl;
	}
	else if (operationSymbol == '*')
	{
		cout << "Result is " << firstNumber * secondNumber << endl;
	}
	else if (operationSymbol == '/')
	{
		cout << "Result is " << firstNumber / secondNumber << endl;
	}
	return 0;
}