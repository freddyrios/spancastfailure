# Span cast failure demo

The issue has been reproduced by running the app in a raspberry pi with raspbian. The app was built in a x64 windows environment, by using dotnet publish, such like: 

    dotnet publish .\SpanCastFailure\ -r linux-arm --self-contained -f net5.0

The issue was reproduced regardless of using `--self-contained` or `--no-self-contained`. The issue was also reproduced by using a recent daily build of net6.0.

When running on windows it prints this as expected `000000`. While running on linux-arm it throws: `System.DataMisalignedException: A datatype misalignment was detected in a load or store instruction.`