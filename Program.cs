class program {
    static void Main(string[] args) {
        while(true) {
        Console.Write("Input DNA : ");
        string halfDNASequence = Console.ReadLine();

        bool TrueorFalse = IsValidSequence(halfDNASequence);

        if(TrueorFalse == true) {
             Console.WriteLine("Current half DNA sequence : " + halfDNASequence);
             Console.Write("Do you want to replicate it ? (Y/N) : ");

            while(true) {
                string YorN = Console.ReadLine();

        if(YorN == "Y") {
                string Replace = ReplicateSeqeunce(halfDNASequence);

                Console.WriteLine("Replicated half DNA sequence : " + Replace);
                break;
        } else if(YorN == "N"){
                break;
        } else {
            Console.Write("Please input Y or N : ");
            }
        } 
        } else {
        Console.WriteLine("That half DNA sequence is invalid.");
    }
        Console.Write("Do you want to process another sequence ? (Y/N) :");

                while(true) {
                    string YorN2 = Console.ReadLine();

                    if (YorN2 == "Y" || YorN2 == "N") {
                        if(YorN2 == "Y"){
                            break;
                    } else if(YorN2 == "N") {
                        Environment.Exit(0);
                    }

                    } else {
                        Console.Write("Please input Y or N : ");
                    }
                }
    }
    }

    static bool IsValidSequence(string halfDNASequence)
{
	foreach(char nucleotide in halfDNASequence)
	{
    	if(!"ATCG".Contains(nucleotide))
    	{
        	return false;
    	}
	}
	return true;
}

static string ReplicateSeqeunce(string halfDNASequence)
{
	string result = "";
	foreach(char nucleotide in halfDNASequence)
	{
    	result += "TAGC"["ATCG".IndexOf(nucleotide)];
	}
	return result;
}


}
