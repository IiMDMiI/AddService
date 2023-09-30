mergeInto(LibraryManager.library, {

    ShowInterstitialExtern: function () {
        ysdk.adv.showFullscreenAdv()
    },

    ShowRewardedExtern: function () {
        ysdk.adv.showRewardedVideo({
            callbacks: {
                onOpen: () => {
                    console.log('Video ad open.');
                },
                onRewarded: () => {
                    console.log('Rewarded!');
                    myGameInstance.SendMessage('YandexAdd', 'OnRewardAddFinished');
                },
                onClose: () => {
                    console.log('Video ad closed.');
                },
                onError: (e) => {
                    console.log('Error while open video ad:', e);
                }
            }
        })
    },

});