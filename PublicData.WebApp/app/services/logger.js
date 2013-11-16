define(function () {
        
        function log(message, data, source, showToast) {
            logIt(message, data, source, showToast, 'info');
        }

        function logError(message, data, source, showToast) {
            logIt(message, data, source, showToast, 'error');
        }

        function logIt(message, data, source, showToast, toastType) {
            source = source ? '[' + source + '] ' : '';
            if (data) {
                //system.log(source, message, data);
            } else {
                //system.log(source, message);
            }
            if (showToast) {
                if (toastType === 'error') {
                    $.gritter.add({
                        // (string | mandatory) the heading of the notification
                        title: 'Uh oh!',
                        // (string | mandatory) the text inside the notification
                        text: message,
                        class_name: 'gritter-error'
                    });
                } else {
                    
                        $.gritter.add({
                            // (string | mandatory) the heading of the notification
                            title: 'Success!',
                            // (string | mandatory) the text inside the notification
                            text: message,
                            class_name: 'gritter-success'
                        });
			
                 

              
                }

            }

        }
    
        var logger = {
            log: log,
            logError: logError
        };

        return logger;
    });