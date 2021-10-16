README

# What is this?
This is a Lib I made for use at my school, but could be helpful to other people to.

# What can it do?
See [Documentation](#Documentation)


# Documentation
- [Init](#ELib.Init)
- [AskUserIfYesOrNo](#ELib.AskUserIfYesOrNo)
- [getSym](#ELib.getSym)
- [getLong](#ELib.getLong)
- [IsConvertableToInt](#ELib.IsConvertableToInt)
- [IsConvertableToLong](#ELib.IsConvertableToLong)
- [getString](#ELib.getString)
- [getUnixTime](#ELib.getUnixTime)
- [CalculateTwoNum](#ELib.CalculateTwoNum)
- [UserChoosesbetween2Posibilitys](#ELib.UserChoosesbetween2Posibilitys)
- [NewTitle](#Elib.NewTitle)


# ELib.Init
Args.: (boolean) enableDebugInfo

Returns: Nothing (void)

Usage: Has to be run at the start of the program / before running any ELib Methods.
It is initializing the Library before it can run.


# ELib.AskUserIfYesOrNo
Args.: (string) question

Returns: boolean

What does it do: Parse a Question, which will be displayed before the input is requested.


# ELib.getSym
Args.: (string) Question, string[] allowedSymbol

Returns: string

What does it do: Gets a Symbol from the User. Parse a Question, which will be displayed before the input is requested. The Question will be asked until the input is equal to one of the allowedSymbols.


# ELib.getLong
Args.: (string) Question

Returns: long

What does it do: Gets a long (int64) from the user. Parse a Question, which will be displayed before the input is requested. The Question will be asked until the input is an input, which can be converted to an long.


# ELib.getInt
Args.: (string) Question

Returns: int

What does it do: Gets a int (int32) from the user. Parse a Question, which will be displayed before the input is requested. The Question will be asked until the input is an input, which can be converted to an int.


# ELib.IsConvertableToInt
Args.: (string) input

Returns: bool

What does it do: Checks if the parsed input can be converted to an int.


# ELib.IsConvertableToLong
Args.: (string) input

Returns: bool

What does it do: Checks if the parsed input can be converted to a long.


# ELib.getString
Args.: (string) Question

Returns: string

What does it do: It asks the parsed Question and simply returns it.


# ELib.getUnixTime
Args.: None

Returns: long

What does it do: Returns the current Unix Time


# ELib.CalculateTwoNum
Args.: (double[]) input, (string) MathSymbol

Returns: double

What does it do: It calculates the Result by calcualting the result of the given Numbers. input[0] *MathSymbol* input[1]


# ELib.UserChoosesbetween2Posibilitys
Args.: (string) Question

Returns: bool

What does it do: It Asks the User to input either 1 or 2. Parse a Question, which will be displayed before the input is requested. The Question will be asked until the input is an input, which is either 1 or 2.


# ELib.NewTitle
Args.: (string) title

Returns: Nothing (void)

What does it do: It sets the Title of the Console to the given argument.
