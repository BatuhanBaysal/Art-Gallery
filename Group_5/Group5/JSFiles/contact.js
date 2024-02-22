function validate() {
        var username = document.forms["contact"][0].value;
        if (username == null || username == "") {
          alert("The name field cannot be left blank.");
          return false;
        }

        var mail = document.forms["contact"][1].value;
        if (mail == null || mail == "") {
          alert("The mail field cannot be left blank.");
          return false;
        }

        var tel = document.forms["contact"][2].value;
        if (tel == null || tel == "") {
          alert("The phone field cannot be left blank.");
          return false;
        }

        var msg = document.forms["contact"][4].value;
        if (msg == null || msg == "") {
          alert("The message field cannot be left blank.");
          return false;
        }
		 window.alert("Your information and message have been sent successfully.");
      }