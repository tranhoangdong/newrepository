console.log('hello');


$(document).on('click', '.js--delete', function () { //  dong nay la bindinbg su kien cho class js--delete.
    // get current Id
    var id = $(this).attr('id');

    // bên dưới là câu lệnh ajax gọi về servẻ để thực hiện lệnh
    $.ajax({
        url: '/Student/Delete?id=' + id, // url là gọi tới địa chỉ nào
        contentType: "application/json; charset=utf-8",
        beforeSend: function (response) { // trước khi gọi thì làm gì
            alert('truoc khi delete student' + id)
            // tam thoi chua xai toi
        },
        success: function (response) { // gọi thành công thì làm gì
            location.reload();
            // sau khi xoa xong thi muon tai lai trang de thay 1 student bi delete
        },
        error: function (xhr, ajaxOptions, thrownError) { // goi bi loi thi lam gi => ti nưa a2 dua tai lieu tham khao
            // loi thi bao loi thoi.
            alert('loi roi Dong oi')
        }
    });
    
  
});
// truyen id ve de delete student do
// sau do load lai trang


//$(document).on('click', '.js--delete', function () {
    
//    // Get id
//    alert($(this).attr('id'))
//    function Delete(id) {
//        //if (confirm(' bạn có muốn xóa không ? ')) {
//        //    $.ajax({
//        //        type: "POST",

//        //    })
//        //}
//    }
//    // go ajax ve
    
//    });
//    // truyen id ve de delete student do
//    // sau do load lai trang
//    location.reload();
//})