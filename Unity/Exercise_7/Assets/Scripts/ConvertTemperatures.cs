using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int fahrenheit, calculatedCelsius, calculatedFahrenheit;
        float fahrenheitFloat, calculatedCelsiusFloat, calculatedFahrenheitFloat;
        float fahrenheitDouble, calculatedCelsiusDouble, calculatedFahrenheitDouble;

        fahrenheit = 0;
        fahrenheitFloat = 0;
        fahrenheitDouble = 0;

        // Original Fahrenheit value
        Debug.Log("Original Fahrenheit with 0: " + fahrenheit);
        Debug.Log("Original Farenheit Float with 0: " + fahrenheitFloat);
        Debug.Log("Original Farenheit Double with 0: " + fahrenheitDouble);

        calculatedCelsius = (fahrenheit - 32) / 9 * 5;
        calculatedCelsiusFloat = (fahrenheitFloat - 32) / 9 * 5;
        calculatedCelsiusDouble = (fahrenheitDouble - 32) / 9 * 5;

        // Calculated Celsius value
        Debug.Log("Calculated Celsius with 0: " + calculatedCelsius);
        Debug.Log("Calculated Celsius Float with 0: " + calculatedCelsius);
        Debug.Log("Calculated Celsius Double with 0: " + calculatedCelsiusDouble);

        calculatedFahrenheit = (calculatedCelsius * 9) / 5 + 32;
        calculatedFahrenheitFloat = (calculatedCelsiusFloat * 9) / 5 + 32;
        calculatedFahrenheitDouble = (fahrenheitDouble * 9) / 5 + 32;

        // Calculated Fahrenheit value
        Debug.Log("Calculated Fahrenheit with 0: " + calculatedFahrenheit);
        Debug.Log("Calculated Fahrenheit Float with 0: " + calculatedFahrenheitFloat);
        Debug.Log("Calculated Fahrenheit Double with 0: " + calculatedFahrenheitDouble);

        fahrenheit = 32;
        fahrenheitFloat = 32;
        fahrenheitDouble = 32;

        // Original Fahrenheit value: 32
        Debug.Log("Original Fahrenheit with 32: " + fahrenheit);
        Debug.Log("Original Fahrenheit Float with 32: " + fahrenheitFloat);
        Debug.Log("Original Farenheit Double with 32: " + fahrenheitDouble);

        calculatedCelsius = (fahrenheit - 32) / 9 * 5;
        calculatedCelsiusFloat = (fahrenheitFloat - 32) / 9 * 5;
        calculatedCelsiusDouble = (fahrenheitDouble - 32) / 9 * 5;

        // Calculated Celsius value: 32
        Debug.Log("Calculated Celsius with 32: " + calculatedCelsius);
        Debug.Log("Calculated Celsius Float with 32: " + calculatedCelsiusFloat);
        Debug.Log("Calculated Celsius Double with 32: " + calculatedCelsiusDouble);

        calculatedFahrenheit = (calculatedCelsius * 9) / 5 + 32;
        calculatedFahrenheitFloat = (calculatedCelsiusFloat * 9) / 5 + 32;
        calculatedFahrenheitDouble = (calculatedCelsiusDouble * 9) / 5 + 32;

        // Calculated Fahrenheit value: 32
        Debug.Log("Calculated Fahrenheit with 32: " + calculatedFahrenheit);
        Debug.Log("Calculated Fahrenheit Float with 32: " + calculatedFahrenheitFloat);
        Debug.Log("Calculated Fahrenheit Double with 32: " + calculatedFahrenheitDouble);

        fahrenheit = 212;
        fahrenheitFloat = 212;
        fahrenheitDouble = 212;

        // Original Fahrenheit value: 212
        Debug.Log("Original Fahrenheit with 212: " + fahrenheit);
        Debug.Log("Original Fahrenheit Float with 212: " + fahrenheitFloat);
        Debug.Log("Original Farenheit Double with 212: " + fahrenheitDouble);

        calculatedCelsius = (fahrenheit - 32) / 9 * 5;
        calculatedCelsiusFloat = (fahrenheitFloat - 32) / 9 * 5;
        calculatedCelsiusDouble = (fahrenheitDouble - 32) / 9 * 5;

        // Calculated Celsius value: 212
        Debug.Log("Calculated Celsius with 212: " + calculatedCelsius);
        Debug.Log("Calculated Celsius Float with 212: " + calculatedCelsiusFloat);
        Debug.Log("Calculated Celsius Double with 212: " + calculatedCelsiusDouble);

        calculatedFahrenheit = (calculatedCelsius * 9) / 5 + 32;
        calculatedFahrenheitFloat = (calculatedCelsiusFloat * 9) / 5 + 32;
        calculatedFahrenheitDouble = (calculatedCelsiusDouble * 9) / 5 + 32;

        // Calculated Fahrenheit value: 212
        Debug.Log("Calculated Fahrenheit with 212: " + calculatedFahrenheit);
        Debug.Log("Calculated Fahrenheit Float with 212: " + calculatedFahrenheitFloat);
        Debug.Log("Calculated Fahrenheit Double with 212: " + calculatedFahrenheitDouble);
    }
}
