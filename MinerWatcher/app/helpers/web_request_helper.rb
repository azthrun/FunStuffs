module WebRequestHelper
  
  TEXTHEADER = {:headers => {"Content-type" => "text/plain"}}
  JSONHEADER = {:headers => {"Accept" => "application/json;"}}
    
  ETHOSDISTRO = "ethosdistro.com/?json=yes"

  #TODO: Test IDs: b57258, 8d2305
  
  def hasNetwork
    response = Rho::Network.get({:url => "http://www.google.com"}).merge(TEXTHEADER)
    ret = (response["status"] == "ok") ? true : false
    ret
  end
  
  def downloadRigStatus
    if hasNetwork
      requestUrl = "http://#{Settings.panelId}.#{ETHOSDISTRO}"
      response = Rho::Network.get({:url => requestUrl}).merge(JSONHEADER)

      if response["status"] == "ok"
        # Analyze Data
        if response["body"].empty?
          # Panel ID has no live rig
          errorMsg = "Panel #{Settings.panelId} has no live rig"
          Rho::WebView.executeJavascript("replacePage('/app/Settings/setup?error=#{errorMsg}');")
        else
          status = storeRigStatus(response["body"])
          if status
            Rho::WebView.executeJavascript("replacePage('/app/Settings/home');")
          else
            errorMsg = "Unable to load rig data"
            Rho::WebView.executeJavascript("replacePage('/app/Settings/setup?error=#{errorMsg}');")
          end
        end
      else
        # GET Request Error
        errorMsg = "Unable to download panel data"
        Rho::WebView.executeJavascript("replacePage('/app/Settings/setup?error=#{errorMsg}');")
      end
    else
      # No Internet Access
      errorMsg = "No internet access is detected"
      Rho::WebView.executeJavascript("replacePage('/app/Settings/setup?error=#{errorMsg}');")
    end
  end
  
  def storeRigStatus(data)
    ret = false
    begin
      feed = Rho::JSON.parse(data)
      
      # Panel overall data
      overall = feed.reject {|k, v| (k == "rigs")}
      Settings.set(Settings::PANELOVERALL, overall.to_json)
      
      # Miner data
      rigs = feed["rigs"]
      Miner.storeMinerStatus(rigs)
      
      ret = true
    rescue
      ret = false
    end
    ret
  end
  
end