// See https://aka.ms/new-console-template for more information
using iSorts.BubbleSort;

Console.WriteLine("Bubble Sort\r\n".PadRight(61, '-'));

int[] inputs = new int[] { 10, 5, 4, 3, 2, 7, 1, 6 };

//GeneralBubbleSort();

//GeneralBubbleSortWithAscendingOption();

//BubbleSortWithDelegate();

//BubbleSortWithEndlessDelegate();

BubbleSortWithFuncAndAction();

//------------------------------------- Implementations ------------------------------------------

void GeneralBubbleSort()
{
    ///General Bubble Sort
    BubbleSort bubbleSortGeneral = new();
    var resultGeneral = bubbleSortGeneral.bubblesort(inputs);
    bubbleSortGeneral.PrintResult(resultGeneral);
}

void GeneralBubbleSortWithAscendingOption()
{
    ///General Bubble Sort with Ascending option
    BubbleSort bubbleSortAsc = new();
    var resultAsc = bubbleSortAsc.bubblesort(inputs, true);
    bubbleSortAsc.PrintResult(resultAsc);
    //-------
    BubbleSort bubbleSortDesc = new();
    var resultDesc = bubbleSortDesc.bubblesort(inputs, false);
    bubbleSortDesc.PrintResult(resultDesc);
}

void BubbleSortWithDelegate()
{
    BubbleSort bubbleSortDelegate = new();
    var resultAsc = bubbleSortDelegate.bubblesort(inputs, bubbleSortDelegate.Asc);
    bubbleSortDelegate.PrintResult(resultAsc);
    
    var resultDesc = bubbleSortDelegate.bubblesort(inputs, bubbleSortDelegate.Desc);
    bubbleSortDelegate.PrintResult(resultDesc);
    
    var resultNewSort = bubbleSortDelegate.bubblesort(inputs, bubbleSortDelegate.newSort);
    bubbleSortDelegate.PrintResult(resultNewSort);
}

void BubbleSortWithEndlessDelegate()
{
    //BubbleSort bubbleSortDelegate = new();
    //Delegate02<int, int, bool> delegate02;

    //delegate02 = bubbleSortDelegate.Asc;
    //var resultAsc = bubbleSortDelegate.bubblesort(inputs, delegate02);
    //bubbleSortDelegate.PrintResult(resultAsc);

    //delegate02 = bubbleSortDelegate.Desc;
    //var resultDesc = bubbleSortDelegate.bubblesort(inputs, delegate02);
    //bubbleSortDelegate.PrintResult(resultDesc);

    //delegate02 = bubbleSortDelegate.newSort;
    //var resultNewSort = bubbleSortDelegate.bubblesort(inputs, delegate02);
    //bubbleSortDelegate.PrintResult(resultNewSort);

}

void BubbleSortWithFuncAndAction()
{
    BubbleSort bubbleSortFuncAndAction = new();
    bubbleSortFuncAndAction.SortOption = bubbleSortFuncAndAction.Desc;
    var result = bubbleSortFuncAndAction.bubblesort(inputs, bubbleSortFuncAndAction.SortOption);
    bubbleSortFuncAndAction.PrintResult(result);
}


