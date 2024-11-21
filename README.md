# Fconverter

A .NET-based command-line tool for transforming data between different formats, initially focusing on JSON to CSV conversion.

## Design 
The tool allows for either a standard input or a filepath and can output either a standard output in the terminal or a file. All other necessary informastion that should not interrupt program flow will be sent to standard error.
![image](https://github.com/user-attachments/assets/ce0ca1f1-fddb-497a-85cd-e0faa1af8dd8)

The overall architecture follows a pipe-and-filter style, where each step in the prcoces is represented by a filter:
![image](https://github.com/user-attachments/assets/bd4bc98f-eec2-41bb-a685-419c5395dc14)

This allows for easy extensibility and reuseability of each filter.

## Roadmap

Create a flexible and extensible data transformation tool that can handle various data formats while maintaining high performance and reliability.

### Planned Features

- JSON to CSV conversion
  - Support for flat JSON structures
  - Support for nested JSON structures
  - Configurable output options
- Error handling and logging

### Future Plans

- Support for additional input formats
- Configuration file support
- Performance optimizations for large files
- Additional output format options

## License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE](LICENSE) file for details.
