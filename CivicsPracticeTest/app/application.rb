require 'rho/rhoapplication'

class AppApplication < Rho::RhoApplication
  def initialize
    @tabs = nil
    @@toolbar = nil
    @default_menu = {
      "Refresh" => :refresh,
      "Logs" => :log,
      "Back" => :back
    }
    super
  end
end
