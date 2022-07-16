function ShowMessage(title, text, theme) {
    window.createNotification({
        closeOnClick: true,
        displayCloseButton: false,
        positionClass: 'nfc-bottom-right',
        showDuration: 4500,
        theme: theme !== '' ? theme : 'success'
    })({
        title: title !== '' ? title : 'Notification',
        message: decodeURI(text)
    })
}