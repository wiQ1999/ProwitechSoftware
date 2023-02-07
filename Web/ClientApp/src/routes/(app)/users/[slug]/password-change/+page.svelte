<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { page } from "$app/stores";
    import { putUserPassword } from "$lib/stores/Users";
    import { openModal } from "svelte-modals";
    import BasePopUp from "$lib/components/base/BasePopUp.svelte";
    import BaseConfirmPopUp from "$lib/components/base/BaseConfirmPopUp.svelte";
    import BaseEditableForm from "$lib/components/base/BaseEditableForm.svelte";

    let password = {
        new: null,
        repeat: null,
    };
    let isEditing = false;
    let formName = "Zmiana hasła użytkownika: " + $formNameStore;

    function onEditingStartHandler() {
        formName = "Edycja hasła użytkownika: " + $formNameStore;
    }

    function onEditingStopHandler() {
        formName = "Zmiana hasła użytkownika: " + $formNameStore;
        resetForm();
    }

    async function onSubmitHandler() {
        const isValid = isFormDataValid();

        if (isValid) {
            let id = $page.params.slug;
            let dto = {
                id: id,
                password: password.new,
            };

            openModal(BaseConfirmPopUp, {
                title: "Potwierdź akcję",
                message: "Czy na pewno chcesz zmienić hasło?",
                onOkay: async () => await putUserPassword(id, dto),
            });
        }

        resetForm();
    }

    function isFormDataValid() {
        if (password.new !== password.repeat) {
            openModal(BasePopUp, {
                title: "Bład",
                message: "Podane hasła muszą być takie same.",
            });

            return false;
        }

        return true;
    }

    function resetForm() {
        password.new = null;
        password.repeat = null;
    }
</script>

<BaseEditableForm
    bind:isEditing
    bind:formName
    {onEditingStartHandler}
    {onEditingStopHandler}
    {onSubmitHandler}
>
    <label for="password" class="block">Nowe hasło</label>
    <input
        type="password"
        bind:value={password.new}
        required
        pattern=".&#123;8,}"
        title="Musi zawierać co najmniej osiem znaków"
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8]"
    />
    <br />
    <label for="repeat" class="block">Powtórz hasło</label>
    <input
        type="password"
        bind:value={password.repeat}
        required
        pattern=".&#123;8,}"
        title="Musi zawierać co najmniej osiem znaków"
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8]"
    />
</BaseEditableForm>
