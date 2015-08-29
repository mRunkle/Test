import wx
class myframe(wx.Frame):
    def __init__(self):
        wx.Frame.__init__(self, None, size=(1200,530))
        

        #SCHEME PANELS
        self.scheme1 = wx.Panel(self, size=(60, 60))
        self.scheme1.SetBackgroundColour((255,255,255))

        
        #GRID SETUP
        self.myGridSizer = wx.GridBagSizer(2, 2) #args = gap spacing
        self.myGridSizer.SetEmptyCellSize((0, 0))

        #SCHEME PANEL POSITIONING
        self.myGridSizer.Add(self.scheme1, pos=(0, 0))#, span=(10,10), flag=wx.EXPAND)


        #TEXT
        #Color 1 ground panel
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


        #button = wx.Button(self,-1,label="Click me !")
        #self.myGridSizer.Add(button, (0,1))
        #self.Bind(wx.EVT_BUTTON, self.OnButtonClick, button)




        self.SetSizer(self.myGridSizer)




        #DATA ENTRY
        #Color 1 entry
        self.entry = wx.TextCtrl(self, -1, value="10,0,150")
        self.myGridSizer.Add(self.entry, pos=(6,1), span=(1,4))#, wx.EXPAND)
        self.Bind(wx.EVT_TEXT_ENTER, self.OnPressEnter, self.entry)
        



    def OnButtonClick(self, event):
        #self.label.SetLabel(self.entry.GetValue() + "(A)")
        #self.entry.SetFocus()
        #self.entry.SetSetSelection(-1, -1)
        #self.set_Color1(0,0,0)
        #self.set_Color1(0,0,0)
        #self.Refresh()
        print "button called"

    def OnPressEnter(self,event):
        self.set_Color1Value()
        self.Refresh()
        print "Enter Call"


    #COLOR 1 METHODS
    def set_Color1Value(self):
        value = str(self.entry.GetValue())
        valueList = value.split(",")
        R = int(valueList[0])
        G = int(valueList[1])
        B = int(valueList[2])

        self.scheme1.SetBackgroundColour((R,G,B))
        #print "this was called"
    


if __name__ == "__main__":
    app = wx.App()
    region = myframe()
    region.Show()
    
    region.set_Color1Value()

    region.Refresh()
    
    app.MainLoop()
