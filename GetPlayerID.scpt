on run
	tell application "Finder"
		set home_path to home as Unicode text
	end tell
	
	display dialog "Start GU game, the press OK to see Opponent list"
	#	log home_path
	set new_path to home_path & "Library:Logs:Immutable:gods"
	#	log new_path
	set file_path to new_path & ":debug.log"
	
	
	# Put Content of file in a String	
	try
		set myText to (read alias file_path) as string
	on error err
		log "Error reading file:" & err as text
	end try
	# Done	
	
	
	# Find first iteration of AppoloID
	set offset_first to offset of "o:PlayerInfo(apolloId: " in myText
	set extractedFirst to text (offset_first + 29) thru -1 of myText
	log extractedFirst
	#End find
	
	# Find second iteration of AppoloID
	set offset_second to offset of "o:PlayerInfo(apolloId: " in extractedFirst
	set extractedString to text (offset_second + 23) thru (offset_second + 29) of extractedFirst
	log extractedString
	#End find
	
	
	
	set op_number to extractedString
	tell application "Firefox"
		open location "https://gudecks.com/meta/player-stats?userId=" & op_number
	end tell
end run