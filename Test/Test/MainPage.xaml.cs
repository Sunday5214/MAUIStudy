using System.Collections.ObjectModel;

namespace Test;

public partial class MainPage : ContentPage
{
	 public ObservableCollection<string> ToolList { get; set; } = new ObservableCollection<string>()
        {
            "청소기",
            "쓰레기봉투",
            "수세미",
            "욕실세제",
            "밀대걸레",
            "고무장갑",
            "주방세제",
            "걸레",
            "청소기",
            "쓰레기봉투",
            "수세미",
            "욕실세제",
            "밀대걸레",
            "고무장갑",
            "주방세제",
            "걸레"
        };

    public MainPage()
    {
        InitializeComponent();
	}


}

