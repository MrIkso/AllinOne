<<<<<<< HEAD
.class public LfixSerial;
.super Ljava/lang/Object;
.source "fixSerial.java"


# direct methods
.method public constructor <init>()V
    .locals 3

    move-object v0, p0

    move-object v2, v0

    invoke-direct {v2}, Ljava/lang/Object;-><init>()V

    return-void
.end method

.method public static GetSerial()Ljava/lang/String;
    .locals 10

    new-instance v6, Ljava/util/Random;

    move-object v9, v6

    move-object v6, v9

    move-object v7, v9

    invoke-direct {v7}, Ljava/util/Random;-><init>()V

    move-object v1, v6

    new-instance v6, Ljava/lang/StringBuilder;

    move-object v9, v6

    move-object v6, v9

    move-object v7, v9

    invoke-direct {v7}, Ljava/lang/StringBuilder;-><init>()V

    move-object v2, v6

    const/4 v6, 0x0

    move v3, v6

    :goto_0
    move v6, v3

    const/16 v7, 0x8

    if-lt v6, v7, :cond_0

    move-object v6, v2

    invoke-virtual {v6}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v6

    invoke-virtual {v6}, Ljava/lang/String;->toUpperCase()Ljava/lang/String;

    move-result-object v6

    move-object v0, v6

    return-object v0

    :cond_0
    move-object v6, v1

    const/16 v7, 0x100

    invoke-virtual {v6, v7}, Ljava/util/Random;->nextInt(I)I

    move-result v6

    move v4, v6

    move-object v6, v2

    move v7, v4

    const/16 v8, 0x100

    or-int/lit16 v7, v7, 0x100

    invoke-static {v7}, Ljava/lang/Integer;->toHexString(I)Ljava/lang/String;

    move-result-object v7

    const/4 v8, 0x1

    invoke-virtual {v7, v8}, Ljava/lang/String;->substring(I)Ljava/lang/String;

    move-result-object v7

    invoke-virtual {v6, v7}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v6

    add-int/lit8 v3, v3, 0x1

    goto :goto_0
.end method
=======
.class public LfixSerial;
.super Ljava/lang/Object;
.source "fixSerial.java"


# direct methods
.method public constructor <init>()V
    .locals 3

    move-object v0, p0

    move-object v2, v0

    invoke-direct {v2}, Ljava/lang/Object;-><init>()V

    return-void
.end method

.method public static GetSerial()Ljava/lang/String;
    .locals 10

    new-instance v6, Ljava/util/Random;

    move-object v9, v6

    move-object v6, v9

    move-object v7, v9

    invoke-direct {v7}, Ljava/util/Random;-><init>()V

    move-object v1, v6

    new-instance v6, Ljava/lang/StringBuilder;

    move-object v9, v6

    move-object v6, v9

    move-object v7, v9

    invoke-direct {v7}, Ljava/lang/StringBuilder;-><init>()V

    move-object v2, v6

    const/4 v6, 0x0

    move v3, v6

    :goto_0
    move v6, v3

    const/16 v7, 0x8

    if-lt v6, v7, :cond_0

    move-object v6, v2

    invoke-virtual {v6}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v6

    invoke-virtual {v6}, Ljava/lang/String;->toUpperCase()Ljava/lang/String;

    move-result-object v6

    move-object v0, v6

    return-object v0

    :cond_0
    move-object v6, v1

    const/16 v7, 0x100

    invoke-virtual {v6, v7}, Ljava/util/Random;->nextInt(I)I

    move-result v6

    move v4, v6

    move-object v6, v2

    move v7, v4

    const/16 v8, 0x100

    or-int/lit16 v7, v7, 0x100

    invoke-static {v7}, Ljava/lang/Integer;->toHexString(I)Ljava/lang/String;

    move-result-object v7

    const/4 v8, 0x1

    invoke-virtual {v7, v8}, Ljava/lang/String;->substring(I)Ljava/lang/String;

    move-result-object v7

    invoke-virtual {v6, v7}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v6

    add-int/lit8 v3, v3, 0x1

    goto :goto_0
.end method
>>>>>>> c39fab210371af58865a746595fdbb0e229bf86e
