# OS IPC Project

## Overview

This project was designed for an Operating Systems course and consists of two C# programs that demonstrate **inter-process communication (IPC)** using standard input and output (pipes). The `LogGenerator` program generates log messages of different levels, and the `LogProcessor` program processes these messages in real-time, highlighting error and warning logs while keeping track of execution time.

## Features

- Generates log messages with varying severity levels (`INFO`, `WARNING`, `ERROR`).
- Processes logs and highlights critical messages.
- Measures execution time for log generation and processing.
- Implements basic error handling for unexpected inputs.

## Technologies Used

- **Language**: C#
- **IPC Method**: Standard Input/Output (`|` pipeline)
- **Framework**: .NET
- **Threading**: `Thread.Sleep()` for simulating real-time log generation

## How It Works

### Log Generator

- Randomly selects a log level.
- Generates a formatted log message.
- Outputs log messages to `stdout` at 1-second intervals.
- Reports total execution time.

### Log Processor

- Reads log messages from `stdin`.
- Categorizes messages:
  - `[ERROR]` messages are flagged with a red alert.
  - `[WARNING]` messages are flagged with a yellow alert.
  - `[INFO]` messages are processed normally.
- Reports total execution time.

## Installation Instructions

1. **Install .NET SDK**:
   Download and install the **.NET SDK (version 6.0 or later)** from the [official website](https://dotnet.microsoft.com/download).

2. **Clone the repository**:

   ```sh
   git clone https://github.com/its-jade/os-ipc-project.git
   cd os-ipc-project
   ```

3. **Ensure your terminal supports IPC**:
   Verify that your terminal or command prompt supports inter-process communication via pipes (`|`).

## Building and Running Instructions

### Compile the Programs

```sh
# Build the LogGenerator project
cd LogGenerator
dotnet build

# Build the LogProcessor project
cd ../LogProcessor
dotnet build
```

### Run Using a Pipe

```sh
dotnet run --project LogGenerator | dotnet run --project LogProcessor
```

## Dependencies

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
