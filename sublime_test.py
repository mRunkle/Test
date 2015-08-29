import wx
class myframe(wx.Frame):
    def __init__(self):
        wx.Frame.__init__(self, None, size=(1200,600))
        

        #SCHEME PANELS
        self.scheme1 = wx.Panel(self, size=(60, 60))
        self.scheme1.SetBackgroundColour("red")

        self.scheme2 = wx.Panel(self, size=(60, 60))
        self.scheme2.SetBackgroundColour("green")

        self.scheme3=wx.Panel(self, size=(60, 60))
        self.scheme3.SetBackgroundColour("blue")

        self.scheme4=wx.Panel(self, size=(60, 60))
        self.scheme4.SetBackgroundColour("yellow")
        
        self.scheme5=wx.Panel(self, size=(60, 60))
        self.scheme5.SetBackgroundColour("orange")
        
        #PRIMARY PANEL
        self.primary1=wx.Panel(self, size=(308, 308)) #"8" compensates for 2p gap between colors
        self.primary1.SetBackgroundColour("red")
        
        #GRID SETUP
        self.myGridSizer = wx.GridBagSizer(2, 2) #args = gap spacing
        self.myGridSizer.SetEmptyCellSize((0, 0))
        
        #SCHEME PANEL POSITIONING
        self.myGridSizer.Add(self.scheme1, pos=(0, 0))#, span=(10,10), flag=wx.EXPAND)
        self.myGridSizer.Add(self.scheme2, pos=(0, 1))#, span=(4,4), flag=wx.ALL)
        self.myGridSizer.Add(self.scheme3, pos=(0, 2))#, span=(4,4), flag=wx.ALL)
        self.myGridSizer.Add(self.scheme4, pos=(0, 3))#, span=(4,4), flag=wx.ALL)
        self.myGridSizer.Add(self.scheme5, pos=(0, 4))#, span=(4,4), flag=wx.ALL)
        
        #PRIMARY PANEL POSITIONING
        self.myGridSizer.Add(self.primary1, pos=(1, 0), span=(5,5))#, flag=wx.ALL)
        
        #?
        self.SetSizer(self.myGridSizer)
        
        '''
        #TEXT
        #RGB label ground panel
        self.textRGB=wx.Panel(self, size=(60, 22))
        self.textRGB.SetBackgroundColour("grey")
        self.myGridSizer.Add(self.textRGB, pos=(6, 0))#, span=(4,4), flag=wx.ALL)
        
        #text application
        self.text1 = wx.StaticText(self.textRGB, label="Color 1", style=2, size=(50, -1))
        font = wx.Font(10, wx.DECORATIVE, wx.ITALIC, wx.BOLD, wx.NORMAL)
        self.text1.SetFont(font)

        self.titleSizer = wx.BoxSizer()
        self.titleSizer.Add(self.text1, flag=wx.CENTER|wx.LEFT|wx.ALIGN_RIGHT, border=10)
        self.textRGB.SetSizer(self.titleSizer)

        self.SetSizer(self.myGridSizer)
        '''
        
        #DATA ENTRY
        self.entry = wx.TextCtrl(self,-1,value=u"Enter text here.")
        self.myGridSizer.Add(self.entry, pos=(6,1), span=(1,4))#, wx.EXPAND)
        self.Bind(wx.EVT_TEXT_ENTER, self.OnPressEnter, self.entry)
        
        self.entry.SetFocus()
        self.entry.SetSelection(-1,1)
        self.Show(True)

    def establishLabels(labelText):
        self.labelText=wx.Panel(self, size=(60, 22))
        self.labelText.SetBackgroundColour("grey")
        self.myGridSizer.Add(self.labelText, pos=(6, 0))#, span=(4,4), flag=wx.ALL)
        
        #text application
        self.text = wx.StaticText(self.labelText, label=labelText, style=2, size=(50, -1))
        font = wx.Font(10, wx.DECORATIVE, wx.ITALIC, wx.BOLD, wx.NORMAL)
        self.text.SetFont(font)

        self.titleSizer = wx.BoxSizer()
        self.titleSizer.Add(self.text, flag=wx.CENTER|wx.LEFT|wx.ALIGN_RIGHT, border=10)
        self.textRGB.SetSizer(self.titleSizer)

        self.SetSizer(self.myGridSizer)

        return self.labelText
        
    def OnButtonClick(self, event):
        self.label.SetLabel(self.entry.GetValue() + "(A)")
        self.entry.SetFocus()
        self.entry.SetSetSelection(-1, -1)

    def OnPressEnter(self,event):
        self.label.SetLabel( self.entry.GetValue() + " (You pressed ENTER)" )
        self.entry.SetFocus()
        self.entry.SetSelection(-1,-1)
        
        createLabels = establishLabels("Color 1")
        print createLabels

if __name__ == "__main__":
    app = wx.App()
    region = myframe()
    region.Show()
    app.MainLoop()