# serial-monitor

## Dependencies
NETCORE31

## Build instructions
```
cd <project-folder>
dotnet build
```

## Syntax
```
serial-monitor <serial-port-identifier> <baudrate>
```

The serial port identifier will depend on the platform and the designation assigned by USB. 
On Windows it might look like this:

```
serial-monitor COM6 9600
```

The program does not exit but will respond to `Ctrl+C` or a kill signal.
