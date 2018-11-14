
    changeCategory();
if ($("#ImageListJsonStr").val()!="")
{
    var imageListJson = JSON.parse($("#ImageListJsonStr").val());
    for (var p in imageListJson) {
        if (imageListJson[p].GoodsOriginalImg!="")
        {
            var file_id = imageListJson[p].GoodsImageId; //这个后台给个文件ID之类的
            var fileName = imageListJson[p].GoodsOriginalImg.substring(imageListJson[p].GoodsOriginalImg.lastIndexOf("/"), imageListJson[p].GoodsOriginalImg.lastIndexOf(".")); //文件名
            var $fileInput = $("#as");
            var dataSrc = imageListJson[p].GoodsOriginalImg; //文件地址
            var $parentFileBox = $fileInput.prev('.parentFileBox');
            //添加父系容器;
            if ($parentFileBox.length <= 0) {
                var div = '<div class="parentFileBox"> \
                				<ul class="fileBoxUl"></ul>\
                			</div>';
                $fileInput.before(div);
                $parentFileBox = $fileInput.prev('.parentFileBox');  
            }
            //添加子容器;
            var li = '<li id="fileBox_' + file_id + '" class="diyUploadHover"> \
                				<div class="viewThumb"></div> \
                				<div class="diyCancel"></div> \
                				<div class="diySuccess"></div> \
                			<div class="diyFileName">' + fileName + '</div>\
                               <input name="filePath" type="hidden" value="" id=' + file_id + '></input>\
                			<div class="diyBar"> \
                					<div class="diyProgress"></div> \
                					<div class="diyProgressText">0%</div> \
                			</div> \
               			</li>';
            $parentFileBox.children('.fileBoxUl').append(li);


            var $fileBox = $parentFileBox.find('#fileBox_' + file_id);

            $fileBox.find('.viewThumb').append('<img onclick="detailBigImage(\'' + file_id + '\',\'' + fileName + '\')" src="' + dataSrc + '" >');
            $("#" + file_id).attr("value", dataSrc);
            var webUploader =$('#as').diyUpload;
            //绑定取消事件;
            $('body .fileBoxUl .diyCancel').on('click', function () { //失去焦点,防止滚动的时候带出键盘
                removeLi($(this).parent('li'), file_id);
            });
            //取消事件;	
            function removeLi($li, file_id) {
                if ($li.siblings('li').length <= 0) {
                    $li.parents('.parentFileBox').remove();
                } else {
                    $li.remove();
                }

            }

        }
           
           

    }
}


       
$('#as').diyUpload({
    // 选完文件后，是否自动上传。
    auto: true,
    url: "/Charm/Upload",
    success: function (file, data) {
        var filePath = data.Url;
        $("#" + file.id).attr("value", filePath);
        console.info(data);
    },
    error: function (err) {
        console.info(err);
    },
    buttonText: '添加图片',
    chunked: true,
    // 分片大小
    chunkSize: 500000 * 1024,
    //最大上传的文件数量
    fileNumLimit: 6,
    //, 总文件大小
    fileSizeLimit: 500000 * 1024,
    //,单个文件大小(单位字节);
    fileSingleSizeLimit: 50000 * 1024,
    accept: {
        title: 'Images',
        extensions: 'gif,jpg,jpeg,bmp,png,bmp',
        mimeTypes: 'image/*'
    }


});

////绑定取消事件;
$('body .fileBoxUl .diyCancel').on('click', function () { //失去焦点,防止滚动的时候带出键盘
    removeLi($(this).parent('li'), file_id);
});
//取消事件;	
function removeLi($li, file_id) {
    if ($li.siblings('li').length <= 0) {
        $li.parents('.parentFileBox').remove();
    } else {
        $li.remove();
    }
}
$(".mark_info").on("click", ".send", function () {

    if ($("#GoodsName").val() == "") {
        ShowErrorInfo("产品名称不能为空");
        return false;
    }
    if ($("#MarketPrice").val() == "") {
        ShowErrorInfo("市场价不能为空");
        return false;
    }
    if ($("#ShopPrice").val() == "") {
        ShowErrorInfo("门市价不能为空");
        return false;
    }
    if ($("#CategoryId").val() == "") {
        ShowErrorInfo("类别二请选择一项");
        return false;
    }
    if ($("input[name='filePath']").length < 1) {
        ShowErrorInfo("请至少上传一张图片");
        return false;

    }
    if ($("input[name='filePath']").length > 5) {
        ShowErrorInfo("最多上传5张图片");
        return false;

    }
    $(".mark,.mark_info").addClass("hide");
    $("#uploadForm").submit();
});

function detailBigImage(fileId, fileName) {
    $("#myModalLabel").text(fileName);
    var filePath = $("#" + fileId).val();
    $("#model_img").attr("src", filePath);
    $("#model_img").addClass("carousel-inner img-responsive img-rounded");
    $("#myModal").modal().css({
        width: 'auto'

    });
    $(".mark,.mark_info").addClass("hide");
}

$('#myModal').on('hide.bs.modal', function () {
    $(".mark,.mark_info").removeClass("hide");
});

//类别菜单联动
function changeCategory() {
    if ($("#GoodsId").val() != "") {
        var categoryId = $("#CategoryId").val();
        var selectValue = $("#CategoryParentId").val();
        $.get("/Personal/GetCategoryInfoByParentId", { parentId: selectValue, categoryId: categoryId }, function (result) {
            $("#CategoryId").empty();
            $("#CategoryId").append(result);
        });
    }
    else {
        var selectValue = $("#CategoryParentId").val();
        $.get("/Personal/GetCategoryInfoByParentId", { parentId: selectValue }, function (result) {
            $("#CategoryId").empty();
            $("#CategoryId").append(result);
        });
    }

}
