# Bastun

Bastun is a simple console application written in C# that converts Fahrenheit to Celsius and gives feedback about sauna temperature based on the Celsius value.

## Features

- Converts Fahrenheit to Celsius
- Provides feedback if the sauna temperature is too cold, too hot, or just right
- Generates a random Fahrenheit value if the user inputs zero
- Ensures user input is numeric

## Usage

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/bastun.git
    ```

2. Navigate to the project directory:
    ```sh
    cd bastun
    ```

3. Build and run the application:
    ```sh
    dotnet run
    ```

4. Follow the on-screen prompts to enter a Fahrenheit value.

## Example

```plaintext
Skriv in Fahrenheit  :
100
Temperaturen i bastun är fantastisk. 37.78 grader. Njut av den!
Press any key to close ...
```

## Code Explanation

```plaintext
fahr_to_cel: Method to convert Fahrenheit to Celsius.
överlagrad: Method to generate a random number between 1 and 100.
Main: The main entry point of the application that handles user input and provides feedback based on the converted temperature.
Contributing
Feel free to submit issues or pull requests if you have any improvements or new features.
```

## License

This project is licensed under the MIT License. See the [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) file for details.
