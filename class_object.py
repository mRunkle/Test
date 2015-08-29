class Notebook:

	def __init__(self, type):
		self.type = type
		self.pageWidth = 0
		self.pageHeight = 0
		self.ruleStyle = ""
		self.binding = ""
			
	def setPageWidth(self, width):
		self.pageWidth = width

	def setPageHeight(self, height):
		self.pageHeight = height

	def setRuleStyle(self, style):
		self.setRuleStyle = style

	def setBinding(self, binding):
		self.setBinding = binding

		
notebooks = [Notebook("steno"), Notebook("standard"), Notebook("memo")]
for i in notebooks:
	print i.type


index = 0
pageWidths = [6, 8.5, 3]
for i in notebooks:
	i.setPageWidth(pageWidths[index])
	index += 1

for i in notebooks:
	print i.pageWidth

	
index = 0
pageHeights = [9, 11.5, 5]
for i in notebooks:
	i.setPageHeight(pageHeights[index])
	index += 1

for i in notebooks:
	print i.pageHeight

	
index = 0
pageRuleStyles = ["Gregg", "College", "None"]
for i in notebooks:
	i.setRuleStyle(pageRuleStyles[index])
	index += 1

for i in notebooks:
	print i.ruleStyle
	
	
index = 0
pageBindings = ["Spiral", "Spiral/Perforated", "Glued"]
for i in notebooks:
	i.setBinding(pageBindings[index])
	index += 1

for i in notebooks:
	print i.binding